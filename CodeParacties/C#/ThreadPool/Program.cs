using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPool
{
    internal class Program
    {
        public static void Run(object obj)
        {
            Console.WriteLine($"Thread Started:  {Thread.CurrentThread.GetHashCode()}");
            Thread.Sleep(5000);
            Console.WriteLine($"Thread Ended:  {Thread.CurrentThread.GetHashCode()}");
        }

        static void Main(string[] args)
        {
            int m, n; 
            System.Threading.ThreadPool.GetMaxThreads(out m, out n);
            Console.WriteLine($"Max :{m} and  Min : {n}");
            System.Threading.ThreadPool.SetMaxThreads(5,5 );
            System.Threading.ThreadPool.SetMinThreads(8,8 );

            for (int i = 1; i <= 20; i++)
            {
                WaitCallback wcb = new WaitCallback(Run);
                System.Threading.ThreadPool.QueueUserWorkItem(wcb,i); 
            }

            Thread.CurrentThread.Join();
        }
    } 
}
