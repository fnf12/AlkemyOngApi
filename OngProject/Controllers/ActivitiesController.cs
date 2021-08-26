using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Helper;
using OngProject.Core.Interfaces.IServices;
using System;
using System.Threading.Tasks;


namespace OngProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly IActivityService _activityService;

        public ActivitiesController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        /// <summary>
        /// Allows to insert an activity
        /// </summary>
        [ProducesResponseType(typeof(GenericResult<ActivityDto>), 200)]
        [ProducesResponseType(typeof(GenericResult<ActivityDto>), 400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(GenericResult<ActivityDto>), 500)]
        [Authorize(Roles = ("Admin"))]
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] ActivityInsertDto activity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    GenericResult<ActivityDto> result = await _activityService.InsertActivity(activity);
                    if (result.IsSuccess)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return BadRequest(result);
                    }
                }
                return BadRequest(new GenericResult<ActivityDto>(null) { IsSuccess = false, Message = "Invalid Model" });
            }
            catch (Exception e)
            {
                return StatusCode(500, new GenericResult<ActivityDto>(null) { IsSuccess = false, Message = e.Message });
            }
        }

        /// <summary>
        /// Allows to insert an activity
        /// </summary>
        [ProducesResponseType(typeof(GenericResult<ActivityDto>), 200)]
        [ProducesResponseType(typeof(GenericResult<ActivityDto>), 400)]
        [ProducesResponseType(typeof(GenericResult<ActivityDto>), 404)]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(GenericResult<ActivityDto>), 500)]
        [Authorize(Roles = ("Admin"))]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateActivity(int id, [FromForm] ActivityUpdateDto activityUpdateDto)
        {
            try
            {
                if (!_activityService.EntityExists(id))
                {
                    return NotFound(new GenericResult<ActivityDto>(null) { IsSuccess = false, Message = "Activity not found" });
                }
                if (ModelState.IsValid)
                {
                    GenericResult<ActivityDto> result = await _activityService.UpdateActivity(id, activityUpdateDto);
                    if (result.IsSuccess)
                    {
                        return Ok(result);
                    }
                    return BadRequest(result);
                }
                return BadRequest(new GenericResult<ActivityDto>(null) { IsSuccess = false, Message = "Invalid Model" });
            }
            catch (Exception e)
            {
                return StatusCode(500, new GenericResult<ActivityDto>(null) { IsSuccess = false, Message = e.Message });
            }
        }
    }
}
