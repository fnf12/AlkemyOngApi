using Microsoft.AspNetCore.Http;
using OngProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.DTOs
{
    public class OrgWithSlidesDto
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public IEnumerable<SlideOrgDto> Slides { get; set; }
    }
}
