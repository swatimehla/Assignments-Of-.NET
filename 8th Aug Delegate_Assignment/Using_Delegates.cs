using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Assignment
{
    //Declaration of Delegates
    public delegate int Multiplydelegate(int x, int y);
    public delegate string WriteNameDelegate(string str);
    public delegate void DivisonDeletgate(int x, int y);
    public delegate void FunDelegate();
    public delegate bool FindDelegate(int x);
    
    class Using_Delegates
    {
        static void Main(string[] args)
        {
            //Instantiation of Delegates
            Multiplydelegate mul_del = new Multiplydelegate(Multiply);
            WriteNameDelegate write_del = new WriteNameDelegate(WriteName);
            DivisonDeletgate div_del = new DivisonDeletgate(Division);
            FunDelegate fun_del = new FunDelegate(fun);
            FindDelegate feven_del = new FindDelegate(FindEven);
            FindDelegate fmul5_del = new FindDelegate(FindMultipleof5);

            //Invoking The delegates
            int Result = mul_del.Invoke(5, 7);
            Console.WriteLine("Result is {0}", Result);

            string str = write_del("SWATI");
            Console.WriteLine(str);

            div_del.Invoke(10, 2);

            fun_del.Invoke();

            if(feven_del.Invoke(20))
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

        public static int Multiply(int x,int y)
        {
            return (x * y);
        }

        public static string WriteName(string name)
        {
            return ("My Name is " + name);
        }

        public static void Division(int x, int y)
        {
            Console.WriteLine("Division Result is : {0}", x / y);
        }

        public static void fun()
        {
            Console.WriteLine("Programming is fun");
        }

        public static bool FindEven(int x)
        {
            if(x%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool FindMultipleof5(int x)
        {
            if (x % 5 == 0)
            {
                return true;
            }
            else
                return false;
        }

    }
}
