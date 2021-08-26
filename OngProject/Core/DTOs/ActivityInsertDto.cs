using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.DTOs
{
    public class ActivityInsertDto
    {
        /// <summary>
        /// Activity name
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Activity content
        /// </summary>
        [Required]
        [StringLength(65535)]
        public string Content { get; set; }

        /// <summary>
        /// Activity image, must be jpg, png, jpeg.
        /// </summary>
        [Required]
        public IFormFile Image { get; set; }
    }
}
