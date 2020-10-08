using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Assignment
{
    class Using_GenericDelegates
    {
        static void Main(string[] args)
        {
            //func Delegate
            Func<int,int,int> mul_del=(x,y) =>
            {
                return (x * y);
            };

           Func<string,string> write_del=(name) =>
            {
                return ("My Name is " + name);
            };

            //Action Delegate
            Action<int,int> div_del= (x,y) =>
            {
                Console.WriteLine("Divide Result is : {0}", x / y);
            };

           Action<string> fun_del=(name)=> 
            {
                Console.WriteLine("Programming is fun"+name);
            };
 
            //Predicate Delegate
           Predicate<int> feven_del= x =>
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

            Predicate<int> fmul5_del=x =>
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

            fun_del.Invoke("FUN");

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
