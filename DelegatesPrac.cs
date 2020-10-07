using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegates
{
    public delegate void MyDelegate(string msg);
    public delegate void MyDelegate2(int i, int j);
    public delegate int MyDelegate3();
    public delegate int MyDelegate4(int i);
    class DelegatesPrac
    {
        static void MethodA(string message) //method from website
        {
            Console.WriteLine(message);
        }

        static void MethodA1(int a,int b)
        {
            Console.WriteLine(a + b);
        }

        static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
        {
            del("Hello World");
        }

        static void InvokeDelegate4(MyDelegate4 del) //it contain Parameter of MyDelegate4
        {
           int value= del(500);
            Console.WriteLine("This is value after Invoking {0}", value);
        }

        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(MethodA);
            del("This is first way");

            MyDelegate del1 = MethodA; //second way 
            del("This is delegate invoking function");

            MyDelegate del3 = MethodA;
            del3.Invoke("This is another way");

            MyDelegate2 del2 = new MyDelegate2(MethodA1);
            del2(5, 6);

            MyDelegate del4 = ClassA.MethodA;
            del4("Hello World");


            MyDelegate del5 = ClassB.MethodB;
            del5("Hello World");

            InvokeDelegate(del4); //another method for Invoking delegte
            InvokeDelegate(del5);

            MyDelegate delCombine = del4 + del5;  //combine del4 and del5 they executing one by one
            delCombine("Hello Both Combination");

            delCombine += del1;   //add del1 also
            delCombine.Invoke("This is by Multicasting");

            delCombine -= del4;  //removing del4
            delCombine("Remove Class A ");

            delCombine = delCombine - del1 - del5; //Removing del1 and del5
            if (delCombine != null)
            {
                delCombine.Invoke("Remove Method Del1 also");
            }
            else
            {
                Console.WriteLine("Delegate is Null");
            }
            //del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            //del("Hello World");

            //Multicasting of Delegates
            MyDelegate3 delegate_int1 = Class1.Method1;
            MyDelegate3 delegate_int2 = Class2.Method2;
            MyDelegate3 delegate_int3 = delegate_int1 + delegate_int2; //here also as assignment bcause it returns value
            Console.WriteLine(delegate_int3()); //print 200

            MyDelegate4 Delegate4del = Class1.Method12;
            int a=Convert.ToInt32( Delegate4del(300));
            Console.WriteLine(a);

            MyDelegate4 Delegate4del1 = Class2.Method22;
            int b = Convert.ToInt32(Delegate4del1(400));
            Console.WriteLine(b);

            InvokeDelegate4(Delegate4del1); //by using Invoke method created by own
             
           // Delegate4del1 += Delegate4del; //Here it work as assignment 
            int b1= Delegate4del1(100);
            Console.WriteLine(b1+"This is Combine but work as assignment");

            Delegate4del = Delegate4del1; // assigning the delegate
            InvokeDelegate4(Delegate4del1);
            
            Console.ReadKey();
        }
    }
   class ClassA
    {
       public  static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }
    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }

    class Class1
    {
        public static int Method1()
        {
            return 100;
        }

        public static int Method12(int i)
        {
           // Console.Write("This is method12");
            return 100 + i;
        }
    }
    class Class2
    {
        public static int Method2()
        {
            return 200;
        }
        public static int Method22(int i)
        {
            return 200 + i;
        }
    }

}
