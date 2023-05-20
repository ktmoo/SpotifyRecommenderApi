using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpotifyRecommenderApi.Models
{
    public class Album
    {
        public string? ID { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public string Name { get; set; }
        [JsonProperty("total_tracks")]
        public int TotalTrack { get; set; }
        public IEnumerable<SimplifiedArtist> Artists { get; set; }
    }
}