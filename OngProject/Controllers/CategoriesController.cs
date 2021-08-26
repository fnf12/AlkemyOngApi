using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Helper.Pagination;
using OngProject.Core.Interfaces.IServices;
using System;
using System.Threading.Tasks;

namespace OngProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Get All Categories.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        [ProducesResponseType(typeof(ResponsePagination<GenericPagination<Category>>), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [HttpGet]
        public async Task<IActionResult> GetPage(int page, int size)
        {
            try
            {
                var categories = await _categoryService.GetCategories(page, size,Url.RouteUrl(nameof(GetPage)));
                return Ok(categories);
            }
            catch
            {
                return StatusCode(500);
            }
        }


        // GET /<CategoriesController>/5
        /// <summary>
        /// Get a category.
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(typeof(Category), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [ProducesResponseType(404)]
        [Authorize(Roles = ("Admin"))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            try
            {
                var category = await _categoryService.GetCategoryById(id);
                if (category == null)
                    return NotFound("Category not found");
                return Ok(category);
            }
            catch
            {
                return StatusCode(500);
            }


        }

        // DELETE /<CategoriesController>/id
        /// <summary>
        /// Deletes category.
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [Authorize(Roles = ("Admin"))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (!_categoryService.EntityExists(id))
                    return NotFound("Category not found");
                if (await _categoryService.DeleteCategory(id))
                    return Ok("Category Deleted");
                else
                    return NotFound("Category not found");
            }
            catch
            {

                return StatusCode(500);
            }
        }

        /// <summary>
        /// Create category.
        /// </summary>
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        [Authorize(Roles = ("Admin"))]
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] CategoryCreateDto categoryCreateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            
            try
            {
                var category = await _categoryService.InsertCategory(categoryCreateDto);
                if (category != null)
                    return Ok(category);
                else
                    return BadRequest("category name already exists");
            }
            catch
            {
                return StatusCode(500);
            }

        }

        /// <summary>
        /// Update a category.
        /// </summary>
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(400)]
        [Authorize(Roles = ("Admin"))]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromForm] CategoryUpdateDto category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _categoryService.UpdateCategory(id, category);
                    if (result != null)
                        return Ok(result);
                    else
                        return NotFound("Category not found");
                }
                return BadRequest("Some properties are not valid");
            }
            catch
            {
                return StatusCode(500);
            }

        }

    }
}
