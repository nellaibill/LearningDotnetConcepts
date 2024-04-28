using Microsoft.Extensions.Configuration;

namespace CSharpConcepts
{
    internal class ConstAndReadOnly
    {
        public const int cmToMeters = 10;  //Compile Time Constants
        public readonly string PI; // Run - Time Constants
        IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();
        public ConstAndReadOnly()
        {
            PI = config["MySettings:PI"]; 
        }
        public void PrintConstAndRead()
        {
            Console.WriteLine("Const: " + cmToMeters + " PI: " + PI);
        }
    }
}
