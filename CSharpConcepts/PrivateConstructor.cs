using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public  class PrivateConstructor
    {
        public string Name { get; set; }
        private PrivateConstructor()
        {
        }

        public static void PrintMessage()
        {
            Console.WriteLine("Hello From Private Constructor Class" );
        }

    }
}
