using System;
using System.Threading;
using System.Diagnostics;

namespace ThreadPooling
{

    class Program
    {
     
        static void Main(string[] args)
        {
            // Creating a Stopwatch object to measure time
            Stopwatch mywatch = new Stopwatch();

           
            Console.WriteLine("Thread Pool Execution");

            // Starting the stopwatch
            mywatch.Start();

            // Calling the ProcessWithThreadPoolMethod
            ProcessWithThreadPoolMethod();

            // Stopping the stopwatch
            mywatch.Stop();

            // Writing the elapsed time to the console
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());

            // Resetting the stopwatch
            mywatch.Reset();

            Console.WriteLine("Thread Execution");
            mywatch.Start();

            // Calling the ProcessWithThreadMethod
            ProcessWithThreadMethod();

            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());
        }

        // Defining a method to process the thread pool
        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                // Queuing a user work item to the thread pool
                ThreadPool.QueueUserWorkItem(Process);
            }
        }

        // Defining a method to process threads
        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                // Creating a new thread object and starting it
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }

        // Defining a method to process the thread
        static void Process(object callback)
        {
            // Creating a nested loop to simulate a long-running process
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {

                }
            }
        }
    }
}
