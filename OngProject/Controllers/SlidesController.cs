using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OngProject.Controllers
{
    [Authorize(Roles = ("Admin"))]
    [Route("[controller]")]
    [ApiController]
    public class SlidesController : ControllerBase
    {
        private readonly ISlideService _slideService;
        public SlidesController(ISlideService slideService)
        {
            _slideService = slideService;
        }

        // GET: Slides
        /// <summary>
        /// Get all Slides.
        /// </summary>
        [ProducesResponseType(typeof(IEnumerable<SlideDto>), 200)]
        [ProducesResponseType(401)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var slidesDtoList = await _slideService.GetAllSlides();

            return Ok(slidesDtoList);
        }

        // GET: Slides/:id
        /// <summary>
        /// Get a Slide by id.
        /// </summary>
        /// <param name="id">A integer number.</param>
        [ProducesResponseType(typeof(Slide), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(401)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSlide(int id)
        {
            var slide = await _slideService.GetSlideById(id);
            if (slide == null)
                return NotFound();

            return Ok(slide);
        }

        // POST: Slides
        /// <summary>
        /// Create a Slide.
        /// </summary>
        /// <param name="slideCreateDto">A type SlideInsertDto object.</param>
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SlideCreateDto slideCreateDto)
        {   
            try
            {
                await _slideService.InsertSlide(slideCreateDto);
                return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(500, e);
            }
        }

        // PUT: Slides/:id
        /// <summary>
        /// Update a Slide specified by id.
        /// </summary>
        /// <param name="id">A integer number.</param>
        /// <param name="slideCreateDto">A type SlideInsertDto object.</param>
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] SlideCreateDto slideCreateDto)
        {
            try
            {
                var result = await _slideService.UpdateSlide(id, slideCreateDto);
                if (result)
                    return Ok();

                return NotFound();
            }
            catch
            {
                return StatusCode(500);
            }

        }

        // DELETE: Slides/:id
        /// <summary>
        /// Delete a Slide specified by id.
        /// </summary>
        /// <param name="id">A integer number.</param>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {


            if (!_slideService.EntityExists(id))
            {
                return NotFound();
            }
            await _slideService.DeleteSlide(id);
            return Ok();
        }

    }
}
