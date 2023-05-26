using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyRecommenderApi.Models
{
    public class Playlist
    {
        public string? ID { get; set; }
        public string Href { get; set; }
        public string Name { get; set; }
        public IEnumerable<Image> Images { get; set; }
    }
}