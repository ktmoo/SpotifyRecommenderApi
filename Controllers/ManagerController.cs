using System.Net.Mail;
using System.Security.AccessControl;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Source.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace SpotifyRecommenderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManagerController : ControllerBase
    {
        protected SpotifyManagerDbContext ManagerDb { get; set; }
        public ManagerController(SpotifyManagerDbContext dependencyInjection)
        {
            ManagerDb = dependencyInjection;
        }
        [HttpGet]
        [Route("GetPlaylists")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        public IActionResult GetPlaylists()
        {
            var playlists = ManagerDb.Playlist;
            
            if (playlists == null)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, "Playlists are unavailable.");
            }
            
            return Ok(JsonSerializer.Serialize(playlists));
        }
    }
}