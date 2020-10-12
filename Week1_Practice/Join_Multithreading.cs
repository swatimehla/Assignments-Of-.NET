using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Join_Multithreading
{
    class Join_Multithreading
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

        static void Main(string[] args)
        {
            Console.WriteLine("Main method Start");
            Join_Multithreading obj = new Join_Multithreading();
            Thread t1 = new Thread(obj.Thread1);
            Thread t2 = new Thread(obj.Thread2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Main method Exit");
            Console.ReadKey();
        }
    }
}
