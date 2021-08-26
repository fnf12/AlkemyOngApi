using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Helper;
using OngProject.Core.Interfaces;
using OngProject.Core.Interfaces.IRepositories;
using OngProject.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace OngProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {

        private readonly IOrganizationService _organizationService;

        public OrganizationController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }

        /// <summary>
        /// Get organization with slides
        /// </summary>
        [ProducesResponseType(typeof(GenericResult<OrgWithSlidesDto>), 200)]
        [ProducesResponseType(typeof(GenericResult<OrgWithSlidesDto>), 500)]
        [HttpGet]
        [Route("public")]
        public IActionResult Public()
        {
            try
            {
                var orgDto =_organizationService.GetOrganizationWithSlides();
                return Ok(orgDto);
            }
            catch (Exception e)
            {

                return StatusCode(500, new GenericResult<OrgWithSlidesDto>(null) { IsSuccess = false, Message = e.Message });
            }
        }
        /// <summary>
        /// Put: public Update Organization
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organizationDto"></param>
        [ProducesResponseType(typeof(KeyNotFoundException),404)]
        [ProducesResponseType(typeof(bool), 200)]
        [ProducesResponseType(typeof(GenericResult<OrgWithSlidesDto>), 500)]
        [Authorize(Roles = ("Admin"))]
        [HttpPut]
        [Route("public/{id}")]
        public async Task <ActionResult> Public(int id, [FromForm] OrganizationDto organizationDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var organizations = await _organizationService.UpdatePublicProperties(id, organizationDto);
                return Ok(organizations);

            }
            catch (KeyNotFoundException nf)
            {

                return NotFound(nf.Message);
            }
            catch (Exception e)
            {

                return StatusCode(500, new GenericResult<OrgWithSlidesDto>(null) { IsSuccess = false, Message = e.Message });
            }
        }

       }
}
