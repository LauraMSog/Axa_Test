using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Runtime.Serialization.Json;
using System.Diagnostics;
using Newtonsoft.Json;
using WebApi.Models;

namespace WebApi
{
    public class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static string jsonUrl = "http://www.mocky.io/v2/5808862710000087232b75ac";

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            GetClients(args).Wait();
        }
        /* Code Test
                private static async Task GetClients()
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    // client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

                    var serializer = new DataContractJsonSerializer(typeof(List<clientsList>));

                    var streamTask = client.GetStreamAsync(url);
                    var repositories = serializer.ReadObject(await streamTask) as List<clientsList>;

                    foreach (var repo in repositories)
                        Debug.WriteLine(repo.name);

                }

                public class clientsList
                {
                    public string name;
                }
         */
        
        // Get data from json
        private static async Task GetClients(string[] args)
        {
            using (var httpClient = new HttpClient())
            {
                string json = await httpClient.GetStringAsync(jsonUrl);
                ClientModel clientModel = JsonConvert.DeserializeObject<ClientModel>(json);
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
