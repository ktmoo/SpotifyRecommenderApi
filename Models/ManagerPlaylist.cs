using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpotifyRecommenderApi.Models
{
    [Table("Playlist")]
    public class ManagerPlaylist
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
    }
}