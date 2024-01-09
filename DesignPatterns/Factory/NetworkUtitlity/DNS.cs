using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NetworkUtitlity
{
    internal class DNS : INetwork
    {
        public void SendRequest()
        {
            Console.WriteLine("Send Request from DNS Class");
        }
    }
}
