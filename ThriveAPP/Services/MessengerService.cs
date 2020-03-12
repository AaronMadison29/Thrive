using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ThriveAPP.Contracts;

namespace ThriveAPP.Services
{
    public class MessengerService : Hub, IMessengerServices
    {
        private readonly IConfiguration _config;
        private readonly ISchoolServices _schoolServices;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly static ConnectionMappings<string> _connections = new ConnectionMappings<string>();

        public MessengerService(IConfiguration config, ISchoolServices schoolServices, UserManager<IdentityUser> userManager)
        {
            _config = config;
            _schoolServices = schoolServices;
            _userManager = userManager;
        }

        public async Task SendMessage(string user, string message)
        {
            var name = Context.User.Identity.Name;
            await Clients.All.SendAsync("ReceiveMessage", name, message);
        }

        public async Task MessageUser(string who, string message)
        {
            var senderName = Context.User.Identity.Name;
            List<Task> tasks = new List<Task>();

            foreach (var connectionId in _connections.GetConnections(who))
            {
                tasks.Add(Clients.Client(connectionId).SendAsync("DirectMessage", senderName, message));
            }

            await Task.WhenAll(tasks);
        }

        public async Task MessageGroup(string message, string group = null)
        {
            var senderName = Context.User.Identity.Name;
            if(group == null)
            {
                group = Context.User.FindFirstValue("Group");
            }

            if(group != null)
            {
                await Clients.Group(group).SendAsync("DirectMessage", senderName, message);
            }

        }

        public override Task OnConnectedAsync()
        {
            string userName = Context.User.Identity.Name;
            string connectionId = Context.ConnectionId;
            string group = Context.User.FindFirstValue("Group");

            if (!_connections.GetConnections(userName).Contains(connectionId))
            {
                _connections.Add(userName, connectionId);
                if(group != null)
                {
                    Groups.AddToGroupAsync(connectionId, group);
                }
            }

            Clients.All.SendAsync("connected", userName);


            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            string userName = Context.User.Identity.Name;
            string connectionId = Context.ConnectionId;
            string group = Context.User.FindFirstValue("Group");

            _connections.Remove(userName, connectionId);
            if (group != null)
            {
                Groups.RemoveFromGroupAsync(connectionId, group);
            }
            Clients.All.SendAsync("Disconnected", userName);


            return base.OnDisconnectedAsync(exception);
        }

        public void MethodToHoldTempCodeUntilAfterMerges()
        {
            //await _userManager.AddClaimAsync(user, new Claim("Group", "diamond"));
        }
    }

    //key will be email addresses
    public class ConnectionMappings<T>
    {
        private readonly Dictionary<T, HashSet<string>> _connections = new Dictionary<T, HashSet<string>>();

        public int Count
        {
            get
            {
                return _connections.Count;
            }
        }
        public void Add(T key, string connectionId)
        {
            //using lock since there is a chance multiple users can access this dictionary at the same time and cause read/write problems
            lock (_connections)
            {
                HashSet<string> connections;
                if(!_connections.TryGetValue(key, out connections))
                {
                    connections = new HashSet<string>();
                    _connections.Add(key, connections);
                }
                lock (connections)
                {
                    connections.Add(connectionId);
                }
            }
        }

        public IEnumerable<string> GetConnections(T key)
        {
            HashSet<string> connections;
            
            if(key != null)
            {
                if (_connections.TryGetValue(key, out connections))
                {
                    return connections;
                }
            }
            return Enumerable.Empty<string>();   
        }

        public void Remove(T key, string connectionId)
        {
            lock (_connections)
            {
                HashSet<string> connections;
                if(!_connections.TryGetValue(key, out connections))
                {
                    return;
                }
                lock (connections)
                {
                    connections.Remove(connectionId);

                    if(connections.Count == 0)
                    {
                        _connections.Remove(key);
                    }

                }

            }
        }



    }
}
