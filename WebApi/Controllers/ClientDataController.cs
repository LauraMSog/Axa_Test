using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Net.Http;
using WebApi.Models;
using System.Text;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]

    public class ClientDataController : Controller
    {
        string jsonUrl = "http://www.mocky.io/v2/5808862710000087232b75ac";

        /* MY_FUNCTIONS */
        /* [HttpGet]
         public async Task<IActionResult> GetClientsList()
         {
             HttpClient http = new HttpClient();
             ClientModel client = null;

             HttpResponseMessage response = await http.GetAsync(jsonUrl);
             if (response.IsSuccessStatusCode)
             {
                 client = await response.Content.ReadAsAsync<ClientModel>();
             }

            // return client;
         }*/

        /* END MY_FUNCTIONS */

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
