using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class StaticConstructor
    {
        public static string LogPath { get; private set; }
        static StaticConstructor()
        {
            LogPath = "abc.txt";
        }
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }


    }
}
