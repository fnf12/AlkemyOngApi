using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OngProject.Controllers;
using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Entities.AuthModel;
using OngProject.Core.Helper;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Services.Auth;
using OngProject.Test.Helper;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OngProject.Test.UnitTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void Users_ShouldGetListOfUsersWhithStatusCode200()
        {
            //Arrange
            UserGetAllDto _user1 = new UserGetAllDto { Email = "mail1@mail.com", FirstName = "Name 1" };
            UserGetAllDto _user2 = new UserGetAllDto { Email = "mail2@mail.com", FirstName = "Name 2" };
            UserGetAllDto _user3 = new UserGetAllDto { Email = "mail3@mail.com", FirstName = "Name 3" };
            List<UserGetAllDto> _list = new List<UserGetAllDto>();
            _list.Add(_user1);
            _list.Add(_user2);
            _list.Add(_user3);
            IEnumerable<UserGetAllDto> en = _list;
            var response = new GenericResult<IEnumerable<UserGetAllDto>>(_list) { IsSuccess = true, Message = "Get All Users" };
            var mockUserService = new Mock<IUserService>();
            mockUserService.Setup(us => us.GetAll()).Returns(Task.FromResult(response));

            //Act
            var controller = new UsersController(mockUserService.Object);
            var testResult = controller.Get();
            var objectResult = testResult.Result as ObjectResult;

            //Assert
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);
        }

        [TestMethod]
        public void Users_ShouldDeleteUserAndReturnStatusCode200()
        {
            //Arrange
            var _user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Email, "admin@mail.com"),
                new Claim("UserId", "023"),
            }));
            var response = new UserManagerResponse
            {
                IsSuccess = true,
                Message = "User Deleted Succesfully"
            };

            var mockUserService = new Mock<IUserService>();
            mockUserService.Setup(us => us.Delete("023")).Returns(Task.FromResult(response));

            //Act
            var controller = new UsersController(mockUserService.Object);
            controller.ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext() { User = _user }
            };
            var testResult = controller.Delete("023");
            var objectResult = testResult.Result as ObjectResult;

            //Assert
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);
        }

        [TestMethod]
        public void Users_ShouldUpdateUserAndReturnStatusCode200Async()
        {
            //Arrange
            var result = new UserManagerResponse
            {
                IsSuccess = true,
                Message = "created"
            };
            var _user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Email, "admin@mail.com"),
                new Claim("UserId", "023"),
            }));
            var dto = new UserUpdateDto
            {
                FirstName = "Admin 2",
                LastName = "L 2",
                Photo = null
            };
            var mockUserService = new Mock<IUserService>();
            mockUserService.Setup(us => us.Delete("023")).Returns(Task.FromResult(result));

            //Act
            var controller = new UsersController(mockUserService.Object);
            controller.ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext() { User = _user }
            };
            var testResult = controller.Delete("023");
            var objectResult = testResult.Result as ObjectResult;

            //Assert
            Assert.IsNotNull(testResult);
            Assert.AreEqual(200, objectResult.StatusCode);
        }
        [TestMethod]
        public void UpdateShouldValidateValidModel()
        {
            //Arrange
            var model = new UserUpdateDto
            {
                FirstName = "Admin 2",
                LastName = "L 2",
                Photo = null
            };
            var context = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();

            //Act
            TypeDescriptor.AddProviderTransparent(new AssociatedMetadataTypeTypeDescriptionProvider(typeof(RegisterViewModel), typeof(RegisterViewModel)), typeof(RegisterViewModel));
            var isModelStateValid = Validator.TryValidateObject(model, context, results, true);

            // Assert
            Assert.IsTrue(isModelStateValid);
        }

        [TestMethod]
        public void UpdateShouldNOTValidateValidModel()
        {
            //Arrange
            var model = new UserUpdateDto();
            var context = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();

            //Act
            TypeDescriptor.AddProviderTransparent(new AssociatedMetadataTypeTypeDescriptionProvider(typeof(RegisterViewModel), typeof(RegisterViewModel)), typeof(RegisterViewModel));
            var isModelStateValid = Validator.TryValidateObject(model, context, results, true);

            // Assert
            Assert.IsFalse(isModelStateValid);
        }
    }
}
