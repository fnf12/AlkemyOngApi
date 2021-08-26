using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Entities.AuthModel;
using OngProject.Core.Helper;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IServices.IAuth;

namespace OngProject.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Get all Users
        /// </summary>
        [ProducesResponseType(typeof(GenericResult<UserDto>), 200)]
        [ProducesResponseType(typeof(GenericResult<UserDto>), 500)]
        [Authorize(Roles = ("Admin"))]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var users = await _userService.GetAll();
                return Ok(users);
            }
            catch (Exception e)
            {

                return StatusCode(500, new GenericResult<UserDto>(null) { IsSuccess = false, Message = e.Message });
            }
        }

        /// <summary>
        /// Delete a User
        /// </summary>
        [ProducesResponseType(typeof(UserManagerResponse), 404)]
        [ProducesResponseType(typeof(UserManagerResponse), 200)]
        [ProducesResponseType(typeof(GenericResult<UserDto>), 500)]
        [Authorize]
        [HttpDelete("id")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var _userId = User.Claims.Where(x => x.Type == "UserId").FirstOrDefault()?.Value;
                if (id != _userId)
                {
                    return BadRequest();
                }

                var result = await _userService.Delete(id);
                if (result.IsSuccess)
                    return Ok(result);
                else
                    return NotFound(result);
            }
            catch (Exception e)
            {

                return StatusCode(500, new GenericResult<UserDto>(null) { IsSuccess = false, Message = e.Message });
            }
        }

        /// <summary>
        /// Update a User
        /// </summary>
        //[ProducesResponseType(typeof(UserManagerResponse), 400)]
        //[ProducesResponseType(typeof(UserManagerResponse), 200)]
        //[ProducesResponseType(typeof(GenericResult<UserDto>), 500)]
        [Authorize]
        [HttpPatch]
        public async Task<IActionResult> UpdateUser([FromForm] UserUpdateDto _user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _userService.Update(_user, User);
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
                return StatusCode(500, new GenericResult<UserDto>(null) { IsSuccess = false, Message = e.Message });
            }
        }
    }
}
