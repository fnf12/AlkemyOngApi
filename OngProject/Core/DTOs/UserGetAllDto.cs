using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.DTOs
{
    /// <summary>
    /// Dto mapped from User entity
    /// </summary>
    public class UserGetAllDto
    {
        /// <summary>
        /// User Id
        /// </summary>
        public string UserId { get; set;}
        /// <summary>
        /// User First Name
        /// </summary>
        public string FirstName { get; set;}

        /// <summary>
        /// User Last Name
        /// </summary>
        public string LastName { get; set;}

        /// <summary>
        /// User email
        /// </summary>
        public string Email { get; set;}

        /// <summary>
        /// User photo
        /// </summary>
        public string Photo { get; set;}

    }
}
