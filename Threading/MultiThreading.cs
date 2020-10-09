using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        string Thread1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread1 at position " + i);
            }
            return ("End of The Thread1");
        }

        string Thread2()
        {
            for (int i = 1; i <= 5; i++)
            {
                if(i==3)
                {
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Thread2 at position " + i);
            }
            return ("End of The Thread2");
        }

        string Thread3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread3 at position " + i);
            }
            return ("End of The Thread3");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            
            Thread t1 = new Thread(delegate()
            {
              Console.WriteLine(  obj.Thread1());
            });
            t1.Start();

            Thread t2 = new Thread(delegate ()
            {
                Console.WriteLine(obj.Thread2());
            });
            t2.Start();
            

            Thread t3 = new Thread(delegate ()
            {
                Console.WriteLine(obj.Thread3());
            });
            t3.Start();

            Console.ReadKey();
        }
    }
}
