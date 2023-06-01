using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace SpotifyRecommenderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetTokenAsync()
        {
            // setting request data for token
            var url = "https://accounts.spotify.com/api/token";
            var clientId = "97620a4c9a68423cbb0d04915fd6f317";
            var clientSecret = "621e146f0a734d9988c4164cc56b8d42";

            // dictionary for structuring respounce data
            var requestData = new Dictionary<string, string>
            {
                { "grant_type", "client_credentials" },
                { "client_id", clientId },
                { "client_secret", clientSecret }
            };

            // post request for token
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, new FormUrlEncodedContent(requestData));

                if (response.IsSuccessStatusCode)
                {
                    // respounse data
                    var responseString = await response.Content.ReadAsStringAsync();

                    //parsing respounse to dictionary
                    var responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(responseString);

                    var accessToken = responseData?["access_token"];

                    return Ok(JsonSerializer.Serialize(accessToken));
                }
                else
                {
                    return BadRequest("access is't given");
                }
            }
        }
    }
}