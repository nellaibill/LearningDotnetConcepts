using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public   class Synchronous_Asynchronous
    {
        public static void FetchDataSynchronously()
        {
            Console.WriteLine("Fetching synchronous data ...");
            Thread.Sleep(3000); 
            Console.WriteLine("Data synchronous fetched.");
        }

        public static void AdditionalSynchrousTask()
        {
            Console.WriteLine("Performing synchronous additional task...");
            Thread.Sleep(3000); 
            Console.WriteLine("Additional synchronous task performed.");
        }
        public  static async Task FetchDataAsynchronously()
        {
            Console.WriteLine("Fetching asynchronous data ...");
            await Task.Delay(3000); // Simulate a time-consuming operation
            Console.WriteLine("Data asynchronous fetched.");
        }

        public  static async Task AdditionalAsynchrousTask()
        {
            Console.WriteLine("Performing asynchronous additional task...");
            await Task.Delay(2000); // Simulate another time-consuming operation
            Console.WriteLine("Additional asynchronous task performed.");
        }
    }
}
