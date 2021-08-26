using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OngProject.Controllers;
using OngProject.Core.DTOs;
using OngProject.Core.Helper;
using OngProject.Core.Interfaces.IServices;
using OngProject.Test.Helper;
using System.IO;
using System.Threading.Tasks;

namespace OngProject.Test.UnitTests
{
    [TestClass]
    public class ActivitiesTests : BaseTests
    {
        [TestMethod]
        public async Task Post_ShouldCreateActivity_ReturnOk200()
        {
            Mock<IFormFile> fileMock = new Mock<IFormFile>();
            string content = "some file content";
            string fileName = "test.jpg";
            MemoryStream ms = new MemoryStream();
            StreamWriter writer = new StreamWriter(ms);
            writer.Write(content);
            writer.Flush();
            ms.Position = 0;
            fileMock.Setup(r => r.OpenReadStream()).Returns(ms);
            fileMock.Setup(r => r.FileName).Returns(fileName);
            fileMock.Setup(r => r.Length).Returns(ms.Length);

            ActivityDto dto = new ActivityDto
            {
                Name = "name",
                Image = "Image",
                Content = "content",
                Id = 1
            };
            GenericResult<ActivityDto> result = new GenericResult<ActivityDto>(dto)
            {
                IsSuccess = true,
                Message = "Activity created succesfully",
            };
            ActivityInsertDto activity = new ActivityInsertDto() { Name = "activity", Image = fileMock.Object, Content = "srdjtvhknfx" };
            Mock<IActivityService> mockActivityService = new Mock<IActivityService>();
            mockActivityService.Setup(x => x.InsertActivity(activity)).Returns(Task.FromResult(result));
            ActivitiesController controller = new ActivitiesController(mockActivityService.Object);
            IActionResult response = await controller.Post(activity);
            ObjectResult _result = response as ObjectResult;


            Assert.AreEqual(200, _result.StatusCode);

        }

        [TestMethod]
        public async Task Update_ShouldUpdateActivity_ReturnOk200()
        {
            Mock<IFormFile> fileMock = new Mock<IFormFile>();
            string content = "some file content";
            string fileName = "test.jpg";
            MemoryStream ms = new MemoryStream();
            StreamWriter writer = new StreamWriter(ms);
            writer.Write(content);
            writer.Flush();
            ms.Position = 0;
            fileMock.Setup(r => r.OpenReadStream()).Returns(ms);
            fileMock.Setup(r => r.FileName).Returns(fileName);
            fileMock.Setup(r => r.Length).Returns(ms.Length);

            ActivityUpdateDto _UpdateDto = new ActivityUpdateDto
            {
                Name = "name",
                Image = fileMock.Object,
                Content = "content"
            };

            ActivityDto dto = new ActivityDto
            {
                Name = "name",
                Image = "Image",
                Content = "content",
                Id = 1
            };
            GenericResult<ActivityDto> result = new GenericResult<ActivityDto>(dto)
            {
                IsSuccess = true,
                Message = "Activity created succesfully",
            };

            Mock<IActivityService> mockActivityService = new Mock<IActivityService>();
            mockActivityService.Setup(x => x.UpdateActivity(1, _UpdateDto)).Returns(Task.FromResult(result));
            mockActivityService.Setup(x => x.EntityExists(dto.Id)).Returns(true);
            ActivitiesController controller = new ActivitiesController(mockActivityService.Object);
            IActionResult response = await controller.UpdateActivity(dto.Id, _UpdateDto);
            ObjectResult _result = response as ObjectResult;


            Assert.AreEqual(200, _result.StatusCode);

        }
    }
}
