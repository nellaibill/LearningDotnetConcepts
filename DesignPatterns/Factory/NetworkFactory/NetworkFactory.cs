using DesignPatterns.Factory.NetworkUtitlity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NetworkFactory
{
    internal class NetworkFactory
    {
        public INetwork GetNetworkInstance(string type)
        {
            INetwork network = null;
            if (type.ToLower().Equals("ping"))
            {
                network = new Ping();
            }
            else if(type.ToLower().Equals("dns"))
            {
                network = new DNS();
            }
            return network;
        }
    }
}
