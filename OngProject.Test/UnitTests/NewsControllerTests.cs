using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OngProject.Controllers;
using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Helper.Pagination;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IServices.IGetUri;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Services;
using OngProject.Core.Services.GetUri;
using OngProject.Infrastructure.Data;
using OngProject.Infrastructure.Repositories;
using OngProject.Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OngProject.Test.UnitTests
{
    [TestClass]
    public class NewsControllerTests : BaseTests
    {
        private readonly ApplicationDbContext _context;
        private readonly NewsController newsController;
        public NewsControllerTests()
        {
            _context = MakeContext("TestsDB");
            IUnitOfWork unitofWork = new UnitOfWork(_context);
            IUriService uriService = new UriService("test/");
            INewsService newsService = new NewsService(unitofWork, uriService);
            newsController = new NewsController(newsService);
        }


        [TestMethod]
        public async Task Post_ShouldCreateNews_ReturnOkResult()
        {
            //Arrange
            var newsDto = new NewsDto() { Name = "news test", Image = null, CategoryId = 1 };

            var newsServiceMock = new Mock<INewsService>();
            newsServiceMock.Setup(sp => sp.InsertNews(newsDto)).Returns(Task.CompletedTask);

            var newsController = new NewsController(newsServiceMock.Object);

            //Act
            var actionResult = await newsController.Post(newsDto);

            //Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }

        [TestMethod]
        public async Task Post_InvalidNewsObject_ReturnBadRequest()
        {
            //Arrange
            var newsDto = new NewsDto() { Name = "news test", Image = null, CategoryId = 1 };

            var newsServiceMock = new Mock<INewsService>();
            newsServiceMock.Setup(sp => sp.InsertNews(newsDto)).Returns(Task.CompletedTask);

            var newsController = new NewsController(newsServiceMock.Object);

            newsController.ModelState.AddModelError("Name", "Error simulated");

            //Act
            var actionResult = await newsController.Post(newsDto);

            //Assert
            Assert.IsInstanceOfType(actionResult, typeof(BadRequestResult));
        }

        [TestMethod]
        public async Task Update_ShouldUpdateNews_ResturnOkResult()
        {
            // Arrange
            var news = new News() { Id = 1, Name = "news test", Image = null, CategoryId = 1 };

            _context.News.Add(news);
            await _context.SaveChangesAsync();

            var newsDto = new NewsUpdateDto() { Name = "news test", Image = null };

            var newsServiceMock = new Mock<INewsService>();
            newsServiceMock.Setup(sp => sp.UpdateNews(1, newsDto)).Returns(Task.FromResult(true));

            var newsController = new NewsController(newsServiceMock.Object);

            // Act
            var actionResult = await newsController.Update(1, newsDto);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }

        [TestMethod]
        public async Task Update_NonExistentNewsID_ReturnNotFoundResult()
        {
            // Arrange
            var news = new News() { Id = 2, Name = "news test", Image = null, CategoryId = 1 };

            _context.News.Add(news);
            await _context.SaveChangesAsync();

            var newsDto = new NewsUpdateDto() { Name = "news modified test", Image = null };

            var newsServiceMock = new Mock<INewsService>();
            newsServiceMock.Setup(sp => sp.UpdateNews(12, newsDto)).Returns(Task.FromResult(false));

            var newsController = new NewsController(newsServiceMock.Object);

            // Act
            var actionResult = await newsController.Update(12, newsDto);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task Update_InvalidNewsObject_ReturnBadRequestObject()
        {
            // Arrange
            var news = new News() { Id = 3, Name = "news test", Image = null, CategoryId = 1 };

            _context.News.Add(news);
            await _context.SaveChangesAsync();

            var newsDto = new NewsUpdateDto() { Image = null };

            newsController.ModelState.AddModelError("Name", "Error simulated");

            // Act
            var actionResult = await newsController.Update(3, newsDto);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(BadRequestObjectResult));
        }

        [TestMethod]
        public async Task GetOneNews_ShouldGetANewsById_ReturnOkObjectResult()
        {
            // Arrange
            _context.News.Add(new News() { Id = 15, Name = "news one", Image = "url/imageTest", CategoryId = 1, Content = "content", CreatedAt = DateTime.Now, IsDeleted = false });
            _context.News.Add(new News() { Id = 16, Name = "news two", Image = "url/imageTest", CategoryId = 1, Content = "content", CreatedAt = DateTime.Now, IsDeleted = false });

            await _context.SaveChangesAsync();

            // Act
            var actionResult = await newsController.GetOneNews(15);
            var contentResult = actionResult as OkObjectResult;
            var responseObject = contentResult.Value as News; 

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkObjectResult));
            Assert.IsNotNull(contentResult.Value);
            Assert.IsInstanceOfType(contentResult.Value, typeof(News));
            Assert.AreEqual(15, responseObject.Id);
        }

        [TestMethod]
        public async Task GetOneNews_NonExistentNewsID_ReturnNotFoundResult()
        {
            // Arrange
            _context.News.Add(new News() { Id = 17, Name = "news two", Image = "url/imageTest", CategoryId = 1, Content = "content", CreatedAt = DateTime.Now, IsDeleted = false });

            await _context.SaveChangesAsync();

            // Act
            var actionResult = await newsController.GetOneNews(18);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task Delete_ShouldDeleteNewsById_ReturnOkResult()
        {
            // Arrange
            _context.News.Add(new News() { Id = 12, Name = "news test", Image = "url/imageTest", CategoryId = 1, Content = "content", CreatedAt = DateTime.Now, IsDeleted = false });

            await _context.SaveChangesAsync();

            // Act
            var actionResult = await newsController.Delete(12);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }

        [TestMethod]
        public async Task Delete_NonExistentNewsID_ReturnNotFoundResult()
        {
            // Act
            var actionResult = await newsController.Delete(14);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }
    }
}
