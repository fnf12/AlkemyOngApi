using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OngProject.Controllers;
using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Helper.Pagination;
using OngProject.Core.Interfaces.IServices.IGetUri;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Services;
using OngProject.Core.Services.GetUri;
using OngProject.Infrastructure.Repositories;
using OngProject.Test.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OngProject.Test.UnitTests
{
    [TestClass]
    public class TestimonialsTests : BaseTests
    {
        [TestMethod]
        public async Task Post_ShouldCreateTestimonial_ResturnOk200()
        {
            // Arranger
            var pruebaBD = "PruebaBd";
            var context = MakeContext(pruebaBD);
            IUnitOfWork unitofWork = new UnitOfWork(context);
            IUriService uriService = new UriService("test/");
            ITestimonialService testimonialService = new TestimonialService(unitofWork, uriService);

            var testimonial = new TestimonialDto() { Name = "testimonio1", Image = null, Content = "asfdqewqe" };
            
            // Act
            var controller = new TestimonialsController(testimonialService);
            var response = await controller.Post(testimonial);

            // Assert
            var okResult = response as OkResult;
            Assert.AreEqual(200, okResult.StatusCode);

        }

        [TestMethod]
        public async Task Update_ShouldUpdateTestimonial_ResturnOk200()
        {
            // Arranger
            var pruebaBD = "PruebaBd";
            var context = MakeContext(pruebaBD);
            IUnitOfWork unitofWork = new UnitOfWork(context);
            IUriService uriService = new UriService("test/");
            ITestimonialService testimonialService = new TestimonialService(unitofWork, uriService);
            context.Testimonials.Add(new Testimonial() { Name = "testimonial1", Content = "asdqweqwfsdfddsd", Image = null });
            context.SaveChanges();
            var testimonialUpdate = new TestimonialEditDto() { Name = "testimonioModify", Content = "123", Image = null};

            // Act
            var controller = new TestimonialsController(testimonialService);
            var response = await controller.Update(1,testimonialUpdate);

            // Assert
            var okResult = response as OkResult;
            Assert.AreEqual(200, okResult.StatusCode);

        }

        [TestMethod]
        public async Task GetTestimonials_ShouldSameNumRecordsWhitAnyContext()
        {
            // Arranger
                //1st Context
                var pruebaBD = "pruebabd";
                var context = MakeContext(pruebaBD);

                context.Testimonials.Add(new Testimonial() { Name = "testimonial1", Content = "asdqweqwfsdfddsd", Image = null });
                context.Testimonials.Add(new Testimonial() { Name = "testimonial2", Content = "asdqweawqeqweqwfsdfddsd", Image = null });
                await context.SaveChangesAsync();

                //2sc Context
                var context2 = MakeContext(pruebaBD);
                IUnitOfWork unitofWork = new UnitOfWork(context2);
                IUriService uriService = new UriService("test/");
                ITestimonialService testimonialService = new TestimonialService(unitofWork, uriService);

            // Act
            var controller = new TestimonialsController(testimonialService);
            var response = await controller.GetTestimonials(0,0);

            // Assert
            var okResult = response as OkObjectResult;
            var testimonials = okResult.Value as ResponsePagination<GenericPagination<Testimonial>>;
            Assert.AreEqual(2, testimonials.TotalRecords);
        }

        [TestMethod]
        public async Task Delete_ByIdNonExistent_ReturnNotFound500()
        {
            // Arranger
            var pruebaBD = "PruebaBd";
            var context = MakeContext(pruebaBD);
            IUnitOfWork unitofWork = new UnitOfWork(context);
            IUriService uriService = new UriService("test/");
            ITestimonialService testimonialService = new TestimonialService(unitofWork, uriService);

            // Act
            var controller = new TestimonialsController(testimonialService);
            var response = await controller.Delete(3);


            // Assert
            var okResult = response as StatusCodeResult;

            Assert.AreEqual(500, okResult.StatusCode);

        }
    }
}
