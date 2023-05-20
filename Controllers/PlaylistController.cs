using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpotifyRecommenderApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace SpotifyRecommenderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlaylistController : ControllerBase
    {
        [HttpGet]
        [Route("{playlistID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetPlaylistAsync(string token, string playlistID)
        {
            var url = $"https://api.spotify.com/v1/playlists/{playlistID}";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var playlist = Newtonsoft.Json.JsonConvert.DeserializeObject<Playlist>(responseString);

                    return Ok(playlist);
                }
                else
                {
                    return BadRequest("playlist is't given");
                }
            }
        }
    }
}