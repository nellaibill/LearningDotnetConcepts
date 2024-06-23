using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        // Private constructor to prevent instantiation
        private Singleton() { }

        // Public method to provide access to the single instance
        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }

        // Example method
        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is working.");
        }
    }

}
