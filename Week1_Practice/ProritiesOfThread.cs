using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Join_Multithreading
{
    class ProritiesOfThread
    {
        void Thread1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread1 at position " + i);
            }
        }

        void Thread2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread2 at position " + i);
            }
        }

        void Thread3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread3 at position " + i);
            }
        }

        void Thread4()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread4 at position " + i);
            }
        }

        void Thread5()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread5 at position " + i);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Main method Start");
            ProritiesOfThread obj = new ProritiesOfThread();
            Thread t1 = new Thread(obj.Thread1);
            Thread t2 = new Thread(obj.Thread2);
            Thread t3 = new Thread(obj.Thread3);
            Thread t4 = new Thread(obj.Thread4);
            Thread t5 = new Thread(obj.Thread5);
            //t5.Priority = ThreadPriority.Highest;
            // t1.Priority = ThreadPriority.Lowest;
            // t2.Priority = ThreadPriority.AboveNormal;
            t3.Priority = ThreadPriority.Normal;
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t5.Priority = ThreadPriority.Highest;
            //t3.Start();
            t3.Priority = ThreadPriority.Lowest;
            t5.Join();
            t3.Join();
            Console.WriteLine("Main method Exit");
            Console.ReadKey();
        }
    }
}
