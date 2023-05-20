using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using SpotifyRecommenderApi.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SpotifyRecommenderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
        public AlbumController()
        {
            
        }
        [HttpGet]
        [Route("{albumID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAlbumAsync(string token, string albumID)
        {
            var url = $"https://api.spotify.com/v1/albums/{albumID}";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var album = Newtonsoft.Json.JsonConvert.DeserializeObject<Album>(responseString);

                    return Ok(album);
                }
                else
                {
                    return BadRequest("album is't given");
                }
            }
        }
    }
}