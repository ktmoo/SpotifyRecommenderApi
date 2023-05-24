using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpotifyRecommenderApi.Models
{
    public class Track
    {
        public string? ID { get; set; }
        public string? Href { get; set; }
        public string? Name { get; set; }
        public Album Album { get; set; }
    }
}