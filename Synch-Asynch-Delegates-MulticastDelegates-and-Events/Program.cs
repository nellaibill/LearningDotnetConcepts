// See https://aka.ms/new-console-template for more information
using Synch_Asynch_Delegates_MulticastDelegates_and_Events;
using System.Numerics;

Factorial obj  = new Factorial();
obj.WhereToSend += DisplayFactorial;
obj.WhereToSend += DisplayFactorialWhenGreaterthan10K;
Console.WriteLine("Started Calculating Factorial");
Thread t1 = new Thread(() => obj.Calculate(1000) );
t1.Start();

Console.WriteLine("Finished Calculating Factorial");

static void DisplayFactorial(BigInteger number)
{
    Console.WriteLine("Result" + number);
}
static void DisplayFactorialWhenGreaterthan10K(BigInteger number)
{
    if (number > 10000)
    {
        Console.WriteLine("Result is big-number");
    }
    else
    {
        Console.WriteLine("Result is small-number");
    }
}