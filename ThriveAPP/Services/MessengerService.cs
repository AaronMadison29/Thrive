using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ThriveAPP.Contracts;

namespace ThriveAPP.Services
{
    public class MessengerService : Hub, IMessengerServices
    {
        private readonly IConfiguration _config;

        public MessengerService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendMessageAsync(string content)
        {
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += "api/Teacher";

            var header = new
            {
                Api_Token = _config.GetValue<string>("Keys:d5cb5eea1d49cdb6bfefa72bbc117814329f1398")
            };

            var json = JsonConvert.SerializeObject(content);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            

            HttpResponseMessage response = await client.PostAsync(url, data);

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();
            }
        }


        public async Task<JObject> GetUsers()
        {
            var url = _config.GetValue<string>("Keys:SendBirdUrl");

            HttpClient client = new HttpClient();

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();
                JObject obj = JsonConvert.DeserializeObject<JObject>(jsonResult);
            }

            return new JObject();
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
