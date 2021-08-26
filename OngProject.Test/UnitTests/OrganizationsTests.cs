using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OngProject.Controllers;
using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Helper;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IServices.IGetUri;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Services;
using OngProject.Core.Services.GetUri;
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
    public class OrganizationsTests : BaseTests
    {
        private object organizationsController;

        [TestMethod]
        public async Task Should_UpdatePublicProperties_ResturnOk200()
        {
            // Arranger
            var pruebaBD = "PruebaBd";
            var context = MakeContext(pruebaBD);
            IUnitOfWork unitofWork = new UnitOfWork(context);
            IOrganizationService organizationService = new OrganizationService(unitofWork);
            context.Organizations.Add(new Organization() { Name = "organization1", Image = null, Address = "sarmiento 1200", Phone = "123-456", Email = "organization@gmail.com", WelcomeText = "Bienvenidos", AboutUsText = "sobre nosotros", FacebookUrl = "ghghghghghghghgh", InstagramUrl = "plklpkplpklpkplkplkplpl", LinkedInUrl = "bngvfbgvfbgbghf" });
            var organizationUpdate = new OrganizationDto() { Name = "organizationModify", Address = "mjukjhgf", Phone = "999-9999", Email = "organizationModify@gmail.com", WelcomeText = "textModify", AboutUsText = "gfrtuhbbnv", FacebookUrl = "fabebbok modify", InstagramUrl = " instagram modify", LinkedInUrl = "linkedIn modify", Image = null };

            context.SaveChanges();
            // Act
            var controller = new OrganizationController(organizationService);
            var response = await controller.Public(1, organizationUpdate);

            // Assert
            var okResult = response as OkObjectResult;
            Assert.AreEqual(200,200);

        }

        [TestMethod]
        public async Task Should_GetOrganizationWtihSlides_IsNotNull()
        {
            // Arranger
            //1st Context
            var pruebaBD = "pruebabd";
            var context = MakeContext(pruebaBD);

            context.Organizations.Add(new Organization() { Name = "organization1", Image = null, Address = "sarmiento 1200", Phone = "123-456", Email = "organization@gmail.com", WelcomeText = "Bienvenidos", AboutUsText = "sobre nosotros", FacebookUrl = "ghghghghghghghgh", InstagramUrl = "plklpkplpklpkplkplkplpl", LinkedInUrl = "bngvfbgvfbgbghf" });
            await context.SaveChangesAsync();

            //2sc Context
            var context2 = MakeContext(pruebaBD);
            IUnitOfWork unitofWork = new UnitOfWork(context2);
            IOrganizationService organizationService = new OrganizationService(unitofWork);

            // Act
            var controller = new OrganizationController(organizationService);
            var response = controller.Public();

            // Assert
            var okResult = response as OkObjectResult;
            var organizations = okResult.Value as GenericResult<OrgWithSlidesDto>;
            Assert.IsNotNull(organizations._object);
        }

        [TestMethod]
        public async Task Update_InvalidPublicProperties_ReturnBadRequestObject()
        {
            // Arrange
            var pruebaBD = "PruebaBd";
            var context = MakeContext(pruebaBD);
            IUnitOfWork unitofWork = new UnitOfWork(context);
            IOrganizationService organizationService = new OrganizationService(unitofWork);
            context.Organizations.Add(new Organization() { Name = "organization1", Image = null, Address = "sarmiento 1200", Phone = "123-456", Email = "organization@gmail.com", WelcomeText = "Bienvenidos", AboutUsText = "sobre nosotros", FacebookUrl = "ghghghghghghghgh", InstagramUrl = "plklpkplpklpkplkplkplpl", LinkedInUrl = "bngvfbgvfbgbghf" });

            context.SaveChanges();

            var organizationUpdateDto = new OrganizationDto() { Image = null };

           

            // Act
            var controller = new OrganizationController(organizationService);
            var response = controller.Public();
            controller.ModelState.AddModelError("Name", "Error simulated");
            var actionResult = await controller.Public(1, organizationUpdateDto);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(BadRequestResult));
        }
    }
}
