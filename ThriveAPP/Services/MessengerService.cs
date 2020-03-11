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


        public async Task SendMessage(string user, string message)
        {
            var name = Context.User.Identity.Name;
            await Clients.All.SendAsync("ReceiveMessage", name, message);
        }
    }
}
