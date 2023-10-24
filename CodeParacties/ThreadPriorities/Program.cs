using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ThreadPriorities
{
    class ThreadDemo
    {
     
        public Double Count { get; set; }
        public void Run()
        {
            Console.WriteLine($"Current Taks name {Thread.CurrentThread.Name}");
            while (true)
            {
                Count++;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //Threads are usefull only then they are getting schedulled. or else those are not use
            //Anytime , we can changes the prioerity of the thread
            //Priority of the thread dose not affects the state of thread 

            List<Thread> lstThread = new List<Thread> ();
            List<ThreadDemo> lstThreadDemo = new List<ThreadDemo>();

            for (int i = 1; i <= 14; i++)
            { 
                ThreadDemo threadDemo = new ThreadDemo();
                Thread thread = new Thread(threadDemo.Run);
              
                if (i % 2 == 0)
                {
                    thread.Name = $"Highest {i}";
                    thread.Priority = ThreadPriority.Highest;
                }
                else 
                {
                    thread.Name = $"Lower{i}";
                    thread.Priority = ThreadPriority.Lowest;
                }
                thread.Start();
                lstThread.Add(thread);
                lstThreadDemo.Add(threadDemo);
            }
             
            foreach (var item in lstThread)
            {
                item.Abort();
            }

            double CompletionPercentages = 0;
            foreach (var item in lstThreadDemo)
            {
                CompletionPercentages += 100 * item.Count / (lstThreadDemo.Sum(x => x.Count));
                Console.WriteLine($"Average completion of the Takes:{100*item.Count/(lstThreadDemo.Sum(x=>x.Count))} where count was {item.Count}");
            }
            Console.WriteLine($"Percentage of completions : {CompletionPercentages}");
            Console.ReadLine();
        }
    }
}
