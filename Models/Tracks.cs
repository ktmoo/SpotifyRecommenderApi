using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyRecommenderApi.Models
{
    public class Tracks
    {
        public IEnumerable<Item> Items { get; set; }
    }
}