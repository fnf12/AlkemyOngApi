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
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET: Contacts
        /// <summary>
        /// Get all Contacts.
        /// </summary>
        [ProducesResponseType(typeof(IEnumerable<Contact>), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(400)]
        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            var contacts = await _contactService.GetContacts();
            return Ok(contacts);
        }

        // POST: Contacts
        /// <summary>
        /// Create a Contact.
        /// </summary>
        /// <param name="contactDto">A type contactDto object.</param>
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ContactDto contactDto)
        {
            try
            {
                await _contactService.InsertContact(contactDto);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
