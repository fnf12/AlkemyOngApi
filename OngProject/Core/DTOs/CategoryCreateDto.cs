using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.DTOs
{
    public class CategoryCreateDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }

    }
}
