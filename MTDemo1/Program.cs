using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace MTDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main running in thread :{Thread.CurrentThread.ManagedThreadId}");
            Stopwatch w = Stopwatch.StartNew();
            Console.WriteLine("Running Seq....");
            M1();
            M2();
            Console.WriteLine($"Time taken to complete {w.ElapsedMilliseconds}");
            Console.WriteLine("Running in multiple threads");
            w = Stopwatch.StartNew();
            // using Thread class
            ThreadStart ts1 = new ThreadStart(M1);
            //ThreadStart ts2 = new ThreadStart(M2);

            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(M2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine($"Time taken to complete {w.ElapsedMilliseconds}");
            // using TPL
            w = Stopwatch.StartNew();
            Console.WriteLine("Running using TPL Parallel class");
            Parallel.Invoke(M1, M2);
            Console.WriteLine($"Time taken to complete {w.ElapsedMilliseconds}");
            w = Stopwatch.StartNew();
            Console.WriteLine("Running using  TPL Task class");
            Task tt1 = new Task(M1);
            Task tt2 = new Task(M2);
            tt1.Start();
            tt2.Start();
            //Task.WaitAll();
            tt1.Wait();
            tt2.Wait();
            Console.WriteLine($"Time taken to complete {w.ElapsedMilliseconds}");
            w = Stopwatch.StartNew();
            Console.WriteLine("Running using  TPL Parallel Loop ");
            Parallel.Invoke(M11, M22);
            Console.WriteLine($"Time taken to complete {w.ElapsedMilliseconds}");
        }

        static void M1()
        {
            //Console.WriteLine($"M1 running in thread :{Thread.CurrentThread.ManagedThreadId}");
            // complex logic 
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(100);
            }
            
        }
        static void M2()
        {
            //Console.WriteLine($"M2 running in thread :{Thread.CurrentThread.ManagedThreadId}");
            // complex logic 
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(100);
            }
            
        }

        static void M11()
        {
            //Console.WriteLine($"M1 running in thread :{Thread.CurrentThread.ManagedThreadId}");
            // complex logic 
            //for (int i = 1; i <= 10; i++)
            Parallel.For(1, 11, i => 
            {
                Thread.Sleep(100);
            });

        }
        static void M22()
        {
            //Console.WriteLine($"M2 running in thread :{Thread.CurrentThread.ManagedThreadId}");
            // complex logic 
            Parallel.For(1, 11, i =>
            {
                Thread.Sleep(100);
            });

        }
    }
}
