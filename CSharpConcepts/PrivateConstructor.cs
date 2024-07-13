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
            Console.WriteLine("Private Constructor");
        }
        private PrivateConstructor(string name)
        {

        }

        public static void PrintMessage()
        {
            Console.WriteLine("Hello From Private Constructor Class" );
        }

    }
}
