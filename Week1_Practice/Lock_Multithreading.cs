using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;           

namespace practice
{
    class Lock_Multithreading
    {

        public void Display()
        {
            lock (this)
            {
                Console.WriteLine("C# is an ");
                Thread.Sleep(10000);
                Console.WriteLine("Object oriented lang");
            }
        }
        static void Main(string[] args)
        {
            Lock_Multithreading p = new Lock_Multithreading();
            Thread t1 = new Thread(p.Display);
            Thread t2 = new Thread(p.Display);
            Thread t3 = new Thread(p.Display);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadKey();
        }
    }
}
