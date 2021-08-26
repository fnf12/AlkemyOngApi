using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
using System.Threading.Tasks;

namespace OngProject.Test.UnitTests
{
    [TestClass]
    public class ContactsTests : BaseTests
    {
        string pruebaBD;
        ApplicationDbContext context;
        Organization org;
        IUnitOfWork unitofWork;
        IOrganizationService organizationService;
        Dictionary<string, string> myconfiguration;
        IConfigurationRoot configuration;

        [TestInitialize]
        public async Task TestInitialize()
        {
            pruebaBD = "PruebaBd";
            context = MakeContext(pruebaBD);
            org = (new Organization() { Name = "org1", Image = "das", AboutUsText = "das", Address = "qeqw", Email = "asd", Phone = "1231234", WelcomeText = "ewqe", FacebookUrl = "asfds", InstagramUrl = "afqeef", LinkedInUrl = "13asd", CreatedAt = DateTime.Now, IsDeleted = false });
            context.Organizations.Add(org);
            await context.SaveChangesAsync();
            unitofWork = new UnitOfWork(context);
            organizationService = new OrganizationService(unitofWork);
            myconfiguration = new Dictionary<string, string>();
            configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(myconfiguration)
                .Build();

        }

        [TestMethod]
        public async Task Post_ShouldCreateContact_ReturnOk200()
        {
            // Arranger
            var mailService = new Mock<IMailService>();
            mailService.Setup(ms => ms.SendMail("Mail", "Body", "subject")).Returns(Task.CompletedTask);
            IContactService contactService = new ContactService(unitofWork, mailService.Object, configuration);

            var contact = new ContactDto() { Name = "testimonio1", Email = "prueba@prueba.com", Message = "asdasdaw13", Phone = "13124534" };

            // Act
            var controller = new ContactsController(contactService);

            var response = await controller.Post(contact);

            // Assert
            var okResult = response as OkResult;
            Assert.AreEqual(200, okResult.StatusCode);

        }

        [TestMethod]
        public async Task Post_ErrorSendMail_NotShouldCreateContact_ReturnStatusCode500()
        {
            // Arranger
            IMailService mailService = new MailService(configuration,organizationService);
            IContactService contactService = new ContactService(unitofWork, mailService, configuration);

            var contact = new ContactDto() { Name = "testimonio1", Email = "prueba@prueba.com", Message = "asdasdaw13", Phone = "13124534" };

            // Act
            var controller = new ContactsController(contactService);
            var response = await controller.Post(contact);

            // Assert
            var okResult = response as StatusCodeResult;
            Assert.AreEqual(500, okResult.StatusCode);

        }

        [TestMethod]
        public async Task GetContanct_ShouldGetAllContacts_ReturnOk200()
        {
            // Arranger
            IMailService mailService = new MailService(configuration, organizationService);
            IContactService contactService = new ContactService(unitofWork, mailService, configuration);

            var contact = new Contact() { Name = "testimonio1", Email = "prueba@prueba.com", Message = "asdasdaw13", Phone = "131245348769" };
            var contact2 = new Contact() { Name = "testimonio2", Email = "prueba2@prueba.com", Message = "asdasdaw11233", Phone = "13125554534" };
            var contact3 = new Contact() { Name = "testimonio3", Email = "prueba3@prueba.com", Message = "asdasdawasd13", Phone = "164563124534" };
            context.Contacts.AddRange(contact, contact2, contact3);
            context.SaveChanges();
            List<Contact> contacts = new List<Contact>() {contact,contact2,contact3};

            //Act
            var controller = new ContactsController(contactService);
            var response = await controller.GetContacts();

            // Assert
      
            var okResult = response as ObjectResult;
            Assert.AreEqual(200, okResult.StatusCode);
            var ResultContacts = okResult.Value as List<Contact>;
            Assert.AreEqual(ResultContacts.Count, contacts.Count);
        }


    }
}
