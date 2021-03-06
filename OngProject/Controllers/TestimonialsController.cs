using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using System;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialsController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        /// <summary>
        /// Get All Testimonials
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(401)]
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetTestimonials(int page, int pageSize)
        {
            var testimonials = await _testimonialService.GetTestimonials(page, pageSize, "/Testimonials");
            return Ok(testimonials);
        }

        /// <summary>
        /// Create a Testimonial
        /// </summary>
        /// <param name="testimonialDto"></param>
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [Authorize(Roles = ("Admin"))]
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] TestimonialDto testimonialDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _testimonialService.Insert(testimonialDto);
                    return Ok();
                }
                return BadRequest();
            }
            catch
            {
                return StatusCode(500);
            }

        }

        /// <summary>
        /// Update a Testimonial
        /// </summary>
        /// <param name="id"></param>
        /// <param name="testimonialDto"></param>
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [Authorize(Roles = ("Admin"))]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] TestimonialEditDto testimonialDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _testimonialService.Update(id, testimonialDto);
                    if (result)
                    {
                        return Ok();
                    }
                    return NotFound();
                }
                return BadRequest("Some properties are not valid");
            }
            catch
            {
                return StatusCode(500);
            }

        }

        /// <summary>
        /// Delete a Testimonial
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [Authorize(Roles = ("Admin"))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                    var result = await _testimonialService.Delete(id); ;
                    if (result)
                    {
                        return Ok("testimonial deleted");
                    }
                    return NotFound("testimonial not found");
            }
            catch
            {
                return StatusCode(500);
            }

        }
    }
}
