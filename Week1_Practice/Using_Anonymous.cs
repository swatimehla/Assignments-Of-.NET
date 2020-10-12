using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Assignment
{
    
    class Using_Anonymous
    {
        static void Main(string[] args)
        {
            Multiplydelegate mul_del = delegate (int x, int y)
            {
                return (x * y);
            };

            WriteNameDelegate write_del = delegate (string name)
            {
                return ("My Name is " + name);
            };

            DivisonDeletgate div_del = delegate (int x, int y)
            {
                Console.WriteLine("Divide Result is : {0}", x / y);
            };

            FunDelegate fun_del = delegate ()
            {
                Console.WriteLine("Programming is fun");
            };

            FindDelegate feven_del = delegate (int x)
            {
                if (x % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };


            FindDelegate fmul5_del = delegate (int x)
            {
                if (x % 5 == 0)
                {
                    return true;
                }
                else
                    return false;
            };

            //Invoking The delegates
            int Result = mul_del.Invoke(5, 7);
            Console.WriteLine("Result is {0}", Result);

            string str = write_del("SWATI");
            Console.WriteLine(str);

            div_del.Invoke(10, 2);

            fun_del.Invoke();

            if (feven_del.Invoke(20))
            {
                Console.WriteLine("Number is EVEN");
            }
            else
            {
                Console.WriteLine("Number is ODD");
            }

            if (fmul5_del.Invoke(30))
            {
                Console.WriteLine("Multiple of 5");
            }
            else
                Console.WriteLine("Not multiple of 5");

            Console.ReadKey();

        }
    }
}
