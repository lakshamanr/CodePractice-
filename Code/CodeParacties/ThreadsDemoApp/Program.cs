using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadsDemoApp
{

    class ThreadDemo
    {
        public string Message { get; set; }
        public int Interval = 1000;
        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"In\t{Thread.CurrentThread.Name} {Message}");
                Thread.Sleep(Interval);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main Methods beging");
            
            ThreadDemo threadDemo = new ThreadDemo() { Message="First Object"}; 
            
            Thread t1 = new Thread(threadDemo.Run);
            t1.Name = "T1";
            t1.Start();

            ThreadDemo thread2 = new ThreadDemo() { Message = "Second Object" };
            threadDemo.Interval = 500;
            Thread t2 = new Thread(thread2.Run);
            t2.Name = "T2";
            t2.Start();

            Console.WriteLine($"Thread status : {Thread.CurrentThread.ThreadState}"); 
          
            Console.WriteLine($"Thread while the join status : {Thread.CurrentThread.ThreadState}");
            t2.Join(3000);// 
            if (t2.IsAlive)
            {
                Console.WriteLine("T1 is Live with in 3 sec");
            }
            Console.WriteLine($"Thread status : {Thread.CurrentThread.ThreadState}");


            Console.WriteLine("main Methods end");
        }
    }
}
