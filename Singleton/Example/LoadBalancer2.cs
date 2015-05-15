using System;
using System.Collections.Generic;

namespace Singleton.Example
{
    /// <summary>
    /// Represents a server machine
    /// </summary>
    class Server
    {
        // Gets or sets server name
        public string Name { get; set; }

        // Gets or sets server IP address
        public string IP { get; set; }
    }

    // Static members are 'eagerly initialized', that is, 
    // immediately when class is loaded for the first time.
    // .NET guarantees thread safety for static initialization
    sealed class LoadBalancer2
    {

        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        private static readonly LoadBalancer2 _instance = new LoadBalancer2();
 
        // Type-safe generic list of servers
        private List<Server> _servers;
        private Random _random = new Random();
 
        // Note: constructor is 'private'
        private LoadBalancer2()
        {
            // Load list of available servers
            _servers = new List<Server> 
            { 
             new Server{ Name = "ServerI", IP = "120.14.220.18" },
             new Server{ Name = "ServerII", IP = "120.14.220.19" },
             new Server{ Name = "ServerIII", IP = "120.14.220.20" },
             new Server{ Name = "ServerIV", IP = "120.14.220.21" },
             new Server{ Name = "ServerV", IP = "120.14.220.22" },
            };
        }
 
        public static LoadBalancer2 GetLoadBalancer()
        {
          return _instance;
        }
 
        // Simple, but effective load balancer
        public Server NextServer
        {
            get
            {
              int r = _random.Next(_servers.Count);
              return _servers[r];
            }
        }
    }
}
