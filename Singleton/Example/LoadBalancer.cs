using System;
using System.Collections.Generic;

namespace Singleton.Example
{
    /// <summary>
    /// the Singleton class
    /// </summary>
    public class LoadBalancer
    {
        private static LoadBalancer _instance;

        public List<string> _servers = new List<string>();

        public Random _random = new Random();

        //lock synchronization object
        private static object lockObj = new object();

        protected LoadBalancer()
        {
            // List of available servers
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (LoadBalancer._instance == null)
            {
                lock (lockObj)
                {
                    if (LoadBalancer._instance == null)
                    {
                        LoadBalancer._instance = new LoadBalancer();
                    }
                }
            }
            return LoadBalancer._instance;
        }

        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);

                return this._servers[r].ToString();
            }
        }
    }
}
