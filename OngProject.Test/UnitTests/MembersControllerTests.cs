using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class MembersControllerTests : BaseTests
    {
        private readonly ApplicationDbContext _context;
        private readonly MembersController membersController;
        public MembersControllerTests()
        {
           _context = MakeContext("TestsDB");
           IUnitOfWork unitofWork = new UnitOfWork(_context);
           IUriService uriService = new UriService("test/");
           IMemberService memberService = new MemberService(unitofWork, uriService);
           membersController = new MembersController(memberService);
        }


        [TestMethod]
        public async Task Post_ShouldCreateMember_ReturnOkResult()
        {
            //Arrange
            var memberDto = new MemberDto() { 
                Name = "member test", 
                Image = null, 
                Description = "test post method",
                FacebookUrl = "url/facebookProfile",
                InstagramUrl = "url/instagramProfile",
                LinkedinUrl = "url/linkedinProfile"
            };

            //Act
            var actionResult = await membersController.Post(memberDto);

            //Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }

        [TestMethod]
        public async Task Post_InvalidMemberObject_ReturnBadRequest()
        {
            //Arrange
            var memberDto = new MemberDto()
            {
                Image = null,
                Description = "test post method",
                FacebookUrl = "url/facebookProfile",
                InstagramUrl = "url/instagramProfile",
                LinkedinUrl = "url/linkedinProfile"
            };

            membersController.ModelState.AddModelError("Name", "Error simulated");

            //Act
            var actionResult = await membersController.Post(memberDto);

            //Assert
            Assert.IsInstanceOfType(actionResult, typeof(BadRequestResult));
        }

        [TestMethod]
        public async Task Update_ShouldUpdateMember_ReturnOkResult()
        {
            // Arrange
            var member = new Member()
            {
                Id = 1,
                Name = "member",
                Image = null,
                Description = "test update method",
                FacebookUrl = "url/facebookProfile",
                InstagramUrl = "url/instagramProfile",
                LinkedinUrl = "url/linkedinProfile",
                CreatedAt = DateTime.Now,
                IsDeleted = false
            };

            _context.Members.Add(member);
            await _context.SaveChangesAsync();

            var memberDto = new MemberEditDto()
            {
                Name = "member modified",
                Image = null,
                Description = "description modified",
                FacebookUrl = "url/facebookProfile",
                InstagramUrl = "url/instagramProfile",
                LinkedinUrl = "url/linkedinProfile"
            };

            // Act
            var actionResult = await membersController.Update(1, memberDto);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }

        [TestMethod]
        public async Task Update_NonExistentMemberID_ReturnNotFoundResult()
        {
            // Arrange
            var member = new Member()
            {
                Id = 2,
                Name = "member",
                Image = null,
                Description = "test update method",
                FacebookUrl = "url/facebookProfile",
                InstagramUrl = "url/instagramProfile",
                LinkedinUrl = "url/linkedinProfile",
                CreatedAt = DateTime.Now,
                IsDeleted = false
            };

            _context.Members.Add(member);
            await _context.SaveChangesAsync();

            var memberDto = new MemberEditDto()
            {
                Name = "member modified",
                Image = null,
                Description = "description modified",
                FacebookUrl = "url/facebookProfile",
                InstagramUrl = "url/instagramProfile",
                LinkedinUrl = "url/linkedinProfile"
            };

            // Act
            var actionResult = await membersController.Update(5, memberDto);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task Update_InvalidMemberObject_ReturnBadRequestObject()
        {
            // Arrange
            var member = new Member()
            {
                Id = 3,
                Name = "member",
                Image = null,
                Description = "test update method",
                FacebookUrl = "url/facebookProfile",
                InstagramUrl = "url/instagramProfile",
                LinkedinUrl = "url/linkedinProfile",
                CreatedAt = DateTime.Now,
                IsDeleted = false
            };

            _context.Members.Add(member);
            await _context.SaveChangesAsync();

            var memberDto = new MemberEditDto()
            {
                Image = null,
                Description = "description modified",
                FacebookUrl = "url/facebookProfile",
                InstagramUrl = "url/instagramProfile",
                LinkedinUrl = "url/linkedinProfile"
            };

            membersController.ModelState.AddModelError("Name", "Error simulated");

            // Act
            var actionResult = await membersController.Update(3, memberDto);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(BadRequestObjectResult));
        }

        [TestMethod]
        public async Task GetPage_ShouldGetObjectsPaginated_ReturnOkObjectResult()
        {
            // Arrange
            _context.Members.Add(new Member() { Id = 10, Name = "member", Image = null, CreatedAt = DateTime.Now, IsDeleted = false });
            _context.Members.Add(new Member() { Id = 11, Name = "member 2", Image = null, CreatedAt = DateTime.Now, IsDeleted = false });

            await _context.SaveChangesAsync();

            // Act
            var actionResult = await membersController.GetPage(1,2);
            var contentResult = actionResult as OkObjectResult;

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkObjectResult));
            Assert.IsNotNull(contentResult.Value);
            Assert.IsInstanceOfType(contentResult.Value, typeof(ResponsePagination<GenericPagination<Member>>));
        }

        [TestMethod]
        public async Task Delete_ShouldDeleteMemberById_ReturnOkResult()
        {
            // Arrange
            _context.Members.Add(new Member() { Id = 12, Name = "member 12", Image = null, CreatedAt = DateTime.Now, IsDeleted = false });

            await _context.SaveChangesAsync();

            // Act
            var actionResult = await membersController.Delete(12);
            
            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }

        [TestMethod]
        public async Task Delete_NonExistentMemberID_ReturnNotFoundResult()
        { 
            // Act
            var actionResult = await membersController.Delete(14);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }
    }
}
