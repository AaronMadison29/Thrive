using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThriveAPP.Contracts
{
    public interface IMessengerServices
    {
        Task<JObject> GetUsers();
        Task SendMessage(string user, string message);
    }
}
