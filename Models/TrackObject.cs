using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyRecommenderApi.Models
{
    public class TrackObject
    {
        public string ID { get; set; }
        public Album Album { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
        public string Href { get; set; }
        public string Name { get; set; }
   }
}