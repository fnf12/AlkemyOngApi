using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OngProject.Controllers
{
    [Authorize(Roles = ("Admin"))]
    [Route("[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;
        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        // GET News
        /// <summary>
        /// Get all News.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetPage(int page, int pageSize)
        {
            var news = await _newsService.GetAllNews(page, pageSize, "/News");
            return Ok(news);
        }

        // GET News/:id
        /// <summary>
        /// Get a news by id.
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneNews(int id)
        {
            try
            {
                if (!_newsService.EntityExists(id))
                {
                    return NotFound();
                }
                var onenews = await _newsService.GetNewsById(id);
                return Ok(onenews);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        // POST News
        /// <summary>
        /// Create a News.
        /// </summary>
        /// <param name="newsDto">A type NewsDto object.</param>
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] NewsDto newsDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _newsService.InsertNews(newsDto);
                    return Ok();
                }
                return BadRequest();
            }
            catch
            {
                return StatusCode(500);
            }

        }

        // PUT News/:id
        /// <summary>
        /// Update a News specified by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newsDto">A type NewsDto object.</param>
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] NewsUpdateDto newsDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _newsService.UpdateNews(id, newsDto);
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

        // DELETE /<NewsController>/id
        /// <summary>
        /// Delete a News specified by id.
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!_newsService.EntityExists(id))
                return NotFound();

            await _newsService.DeleteNews(id);

            return Ok();
        }


    }
}
