using Microsoft.AspNetCore.Mvc;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Services;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using OngProject.Core.DTOs;
using OngProject.Core.Mapper;
using System;
using OngProject.Core.Entities;

namespace OngProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        // GET: Comments/:id
        /// <summary>
        /// Get a Comment by id.
        /// </summary>
        /// <param name="id">A integer number.</param>
        [ProducesResponseType(typeof(Comment), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(401)]
        [Route("/posts/{id}/[controller]")]
        [HttpGet]
        public IActionResult GetCommentsByPost(int id)
        {
            var comment = _commentService.GetCommentByPost(id);
            if (comment == null)
                return NotFound();

            return Ok(comment);
        }

        // GET: Comments
        /// <summary>
        /// Get all Comments.
        /// </summary>
        [ProducesResponseType(typeof(IEnumerable<CommentDto>), 200)]
        [ProducesResponseType(401)]
        [Authorize(Roles = ("Admin"))]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return  Ok(await _commentService.GetComments());
        }

        // DELETE: Comments/:id
        /// <summary>
        /// Delete a Comment specified by id.
        /// </summary>
        /// <param name="id">A integer number.</param>
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(403)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            if (!await _commentService.ValidateCreatorOrAdminAsync(User, id))
            {
                return Forbid();
            }

            if (!_commentService.EntityExists(id))
            {
                return NotFound();
            }
            await _commentService.DeleteComment(id);
            return Ok();
        }

        // POST: Comments
        /// <summary>
        /// Create a Comment.
        /// </summary>
        /// <param name="comment">A type CommentInsertDto object.</param>
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [Authorize]
        [HttpPost]
        public IActionResult Insert(CommentInsertDto comment)
        {
            if (!User.Claims.Any())
            {
                return BadRequest("You must be logged to comment");
            }
            if (ModelState.IsValid)
            {
                var result = _commentService.InsertComment(comment, User);

                if (result.Result.IsSuccess)
                {
                    return Ok(result.Result.Message);
                }
                else
                {
                    return BadRequest(result.Result.Message);
                }
            }
            return BadRequest("Some properties are not valid");
        }

        // PUT: Comments/:id
        /// <summary>
        /// Update a Comment specified by id.
        /// </summary>
        /// <param name="id">A integer number.</param>
        /// <param name="comment">A type comment object.</param>
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCommentsAsync(int id, CommentUpdateDto comment)
        {
            try
            {
                if (!await _commentService.ValidateCreatorOrAdminAsync(User, comment.Id))
                {
                    return Forbid();
                }
                if (!_commentService.EntityExists(id))
                {
                    return NotFound("Comment doesn't exists");
                }
                if (ModelState.IsValid)
                {
                    var result = _commentService.UpdateComment(id, comment).Result;
                    if (result.IsSuccess)
                    {
                        return Ok(result);
                    }
                    return BadRequest(result);
                }
                return BadRequest("Some properties are not valid");
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }

        }

    }
}