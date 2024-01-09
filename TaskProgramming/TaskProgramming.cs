using System.Security;
using System.Text.Json;

public class TaskProgramming
{

    public static int sum = 0;
    static Semaphore semaphore = new Semaphore(2, 2);
    static void Main(String[] args)
    {
        Console.WriteLine("Main Thread");

        for (int i = 0; i < 5; i++)
        {
            int taskNumber = i + 1;
           // ThreadPool.QueueUserWorkItem(new WaitCallback(MethodThreadPool,taskNumber));
        }
    }
    static void MethodThreadPool(object  obj)
    {
        int i = (int)obj;

        Console.WriteLine("Backgroud" + Thread.CurrentThread);
        Console.WriteLine("Int i =" + i);
    }
    static void Method1()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Started ");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Working ");
        semaphore.WaitOne();
        Thread.Sleep(2000);
        semaphore.Release();
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Completed ");
    }

    static void Addition()
    {
        for (int i = 0; i < 5000; i++)
        {
            //sum++;
            Interlocked.Increment(ref sum);
        }
    }
    static void Method2()
    {
        Console.WriteLine("Method 2 Completed");
    }
    static void SomeHeavyTask()
    {
        for (int i = 0; i < 10000; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void SomeHeavyTask1()
    {
        for (int i = 0; i < 10000; i++)
        {
            Console.WriteLine("tes");
        }
    }
    public static void write(char c)
    {
        int i = 1000;
        while (i-- > 0)
        {
            Console.Write(c);
        }
    }
}