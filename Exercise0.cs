//using System;
//using System.Threading;


//class ThreadPoolDemo
//{
//    // Task1 method runs a string loop that is executed by a thread from the thread pool
//    public void task1(object obj)
//    {
//        for (int i = 0; i <= 2; i++)
//        {
//            Console.WriteLine("Task 1 is being executed");
//        }
//    }

//    // Task2 method runs a string loop that is executed by a thread from the thread pool
//    public void task2(object obj)
//    {
//        for (int i = 0; i <= 2; i++)
//        {
//            Console.WriteLine("Task 2 is being executed");
//        }
//    }

//    static void Main()
//    {
//        // Creating an instance of the ThreadPoolDemo class
//        ThreadPoolDemo tpd = new ThreadPoolDemo();


//        for (int i = 0; i < 2; i++)
//        {
//            // Queuing the task1 and task2 methods to the thread pool
//            ThreadPool.QueueUserWorkItem(tpd.task1);
//            ThreadPool.QueueUserWorkItem(tpd.task2);
//        }

//        Console.Read();
//    }
//}
