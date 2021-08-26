using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OngProject.Controllers;
using OngProject.Core.DTOs;
using OngProject.Core.Entities.AuthModel;
using OngProject.Core.Helper;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IServices.IAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OngProject.Test.UnitTests
{
    [TestClass]
    public class AuthorizationTests
    {
        IConfiguration configuration;
        public AuthorizationTests()
        {
            var myConfiguration = new Dictionary<string, string>
            {
                {"MailService:WelcomeMessage", "Test String"},
            };
            configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(myConfiguration)
                .Build();
        }

        [TestMethod]
        public void Register_ShouldRegisterAUserAndReturnTokenWithStatusCode200()
        {
            //Arrange
            var registerViewModel = new RegisterViewModel();
            var result = new UserManagerResponse
            {
                IsSuccess = true,
                Message = "Token"
            };
            var mockAuthUserService = new Mock<IAuthUserService>();
            mockAuthUserService.Setup(us => us.RegisterUserAsync(registerViewModel)).Returns(Task.FromResult(result));
            var mockMailService = new Mock<IMailService>();
            mockMailService.Setup(ms => ms.SendMail("mail", "body", "subject")).Returns(Task.CompletedTask);

            //Act
            var controller = new AuthController(mockAuthUserService.Object, mockMailService.Object, configuration);
            var testResult = controller.RegisterAsync(registerViewModel);
            var okObjectResult = testResult.Result as OkObjectResult;
            UserManagerResponse response = (UserManagerResponse)okObjectResult.Value;

            //Assert
            Assert.IsNotNull(okObjectResult);
            Assert.AreEqual("Token", response.Message);
            Assert.IsTrue(response.IsSuccess);
            Assert.AreEqual(200, okObjectResult.StatusCode);
        }

        [TestMethod]
        public void Register_ShouldNOTRegisterAUserAndReturnStatusCode400()
        {
            // Arrange
            var registerViewModel = new RegisterViewModel();
            var result = new UserManagerResponse
            {
                IsSuccess = false,
                Message = "Not Registered"
            };
            var mockAuthUserService = new Mock<IAuthUserService>();
            mockAuthUserService.Setup(us => us.RegisterUserAsync(registerViewModel)).Returns(Task.FromResult(result));
            var mockMailService = new Mock<IMailService>();
            mockMailService.Setup(ms => ms.SendMail("mail", "body", "subject")).Returns(Task.CompletedTask);

            //Act
            var controller = new AuthController(mockAuthUserService.Object, mockMailService.Object, configuration);
            var testResult = controller.RegisterAsync(registerViewModel);
            var badRequestObjectResult = testResult.Result as BadRequestObjectResult;
            UserManagerResponse response = (UserManagerResponse)badRequestObjectResult.Value;

            //Asert
            Assert.IsNotNull(badRequestObjectResult);
            Assert.AreEqual("Not Registered", response.Message);
            Assert.IsFalse(response.IsSuccess);
            Assert.AreEqual(400, badRequestObjectResult.StatusCode);
        }

        [TestMethod]
        public void RegisterShouldValidateInvalidModel()
        {
            //Arrange
            var model = new RegisterViewModel();
            var context = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();

            //Act
            TypeDescriptor.AddProviderTransparent(new AssociatedMetadataTypeTypeDescriptionProvider(typeof(RegisterViewModel), typeof(RegisterViewModel)), typeof(RegisterViewModel));
            var isModelStateValid = Validator.TryValidateObject(model, context, results, true);

            //Assert
            Assert.IsFalse(isModelStateValid);
        }

        [TestMethod]
        public void RegisterShouldValidateValidModel()
        {
            //Arrange
            var model = new RegisterViewModel()
            {
                Email = "admin@mail.com",
                FirstName = "Jhon",
                LastName = "Doe",
                Password = "12345",
                ConfirmPassword = "12345"
            };
            var context = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();

            //Act
            TypeDescriptor.AddProviderTransparent(new AssociatedMetadataTypeTypeDescriptionProvider(typeof(RegisterViewModel), typeof(RegisterViewModel)), typeof(RegisterViewModel));
            var isModelStateValid = Validator.TryValidateObject(model, context, results, true);

            //Assert here
            Assert.IsTrue(isModelStateValid);
        }

        [TestMethod]
        public void Login_ShouldLoginAUserAndReturnTokenWithStatusCode200()
        {
            //Arrange
            var loginViewModel = new LoginUserModel();
            var result = new UserManagerResponse
            {
                IsSuccess = true,
                Message = "Token"
            };
            var mockAuthUserService = new Mock<IAuthUserService>();
            mockAuthUserService.Setup(us => us.Login(loginViewModel)).Returns(Task.FromResult(result));
            var mockMailService = new Mock<IMailService>();
            mockMailService.Setup(ms => ms.SendMail("mail", "body", "subject")).Returns(Task.CompletedTask);

            //Act
            var controller = new AuthController(mockAuthUserService.Object, mockMailService.Object, configuration);
            var testResult = controller.Login(loginViewModel);
            var okObjectResult = testResult.Result as OkObjectResult;
            UserManagerResponse response = (UserManagerResponse)okObjectResult.Value;

            //Assert
            Assert.IsNotNull(okObjectResult);
            Assert.AreEqual("Token", response.Message);
            Assert.IsTrue(response.IsSuccess);
            Assert.AreEqual(200, okObjectResult.StatusCode);
        }

        public void Login_ShouldNOTLoginAUserAndReturnStatusCode400()
        {
            //Arrange
            var loginViewModel = new LoginUserModel();
            var result = new UserManagerResponse
            {
                IsSuccess = false,
                Message = "Not Registered"
            };
            var mockAuthUserService = new Mock<IAuthUserService>();
            mockAuthUserService.Setup(us => us.Login(loginViewModel)).Returns(Task.FromResult(result));
            var mockMailService = new Mock<IMailService>();
            mockMailService.Setup(ms => ms.SendMail("mail", "body", "subject")).Returns(Task.CompletedTask);

            //Act
            var controller = new AuthController(mockAuthUserService.Object, mockMailService.Object, configuration);
            var testResult = controller.Login(loginViewModel);
            var okObjectResult = testResult.Result as OkObjectResult;
            UserManagerResponse response = (UserManagerResponse)okObjectResult.Value;

            //Assert
            Assert.IsNotNull(okObjectResult);
            Assert.AreEqual("Not Registered", response.Message);
            Assert.IsFalse(response.IsSuccess);
            Assert.AreEqual(400, okObjectResult.StatusCode);
        }

        [TestMethod]
        public void LoginShouldValidateValidModel()
        {
            //Arrange
            var model = new LoginUserModel()
            {
                Email = "admin@mail.com",
                Password = "123455"
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
        public void LoginShouldNOTValidateValidModel()
        {
            //Arrange
            var model = new LoginUserModel();
            var context = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();

            //Act
            TypeDescriptor.AddProviderTransparent(new AssociatedMetadataTypeTypeDescriptionProvider(typeof(RegisterViewModel), typeof(RegisterViewModel)), typeof(RegisterViewModel));
            var isModelStateValid = Validator.TryValidateObject(model, context, results, true);

            // Assert
            Assert.IsFalse(isModelStateValid);
        }
        [TestMethod]
        public void MeShouldReturnUserDto()
        {
            //Arrange
            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                 new Claim(ClaimTypes.Email, "admin@mail.com"),
                new Claim("UserId", "023"),
            }));
            var mockAuthUserService = new Mock<IAuthUserService>();
            mockAuthUserService.Setup(us => us.MeAsync(user)).Returns(Task.FromResult(new UserDto
            {
                Email = "admin@mail.com",
                FirstName = "Jhon",
                LastName = "Doe",
                Photo = ""
            }));
            var mockMailService = new Mock<IMailService>();
            mockMailService.Setup(ms => ms.SendMail("mail", "body", "subject")).Returns(Task.CompletedTask);

            //Act
            var controller = new AuthController(mockAuthUserService.Object, mockMailService.Object, configuration);
            controller.ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext() { User = user }
            };
            var testResult = controller.Me();
            var okObjectResult = testResult.Result as OkObjectResult;
            var response = okObjectResult.Value as GenericResult<UserDto>;

            // Assert
            Assert.AreEqual(response._object.Email, "admin@mail.com");
        }


    }
}
