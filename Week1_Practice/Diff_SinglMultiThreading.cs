using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Difference
{
    class Diff_SinglMultiThreading
    {
        void Thread1()
        {
            int Count = 0;
            for (int i = 1; i <= 100000000; i++)
            {
                Count++;
            }
            Console.WriteLine("Counter Value : {0} ",Count); 
        }

        void Thread2()
        {
            int Count = 0;
            for(int i=1;i<=10000000;i++)
            {
                Count++;
            }
            Console.WriteLine("Counter Value : {0} ", Count);
        }

        static void Main(string[] args)
        {
            Diff_SinglMultiThreading p = new Diff_SinglMultiThreading(); //object Intialization

            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Stopwatch start");
            sw.Start();
            p.Thread1();// for single threading
            p.Thread2();//for single Threading
            Console.WriteLine("Single Threaded Stopwatch Reading : {0} ",sw.ElapsedMilliseconds);

            Stopwatch sw1 = new Stopwatch();
            Console.WriteLine("Stopwatch Start");
            sw1.Start();
            Thread t1 = new Thread(p.Thread1);//for MultiThreading
            t1.Start();
            Thread t2 = new Thread(p.Thread2);//for Multithreading
            t2.Start();
            Console.WriteLine("MultiThreading Stopwatch Reading : {0} ", sw1.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
