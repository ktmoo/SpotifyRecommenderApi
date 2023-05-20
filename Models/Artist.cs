using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpotifyRecommenderApi.Models
{
    [ApiController]
    [Route("api/[controller]")]
    public class Artist : ControllerBase
    {
        public string? ID { get; set; }
        public string? Href { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Image> Images { get; set; }
    }
}