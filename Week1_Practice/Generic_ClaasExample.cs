using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic__Class
{
    class Generic_ClaasExample
    {
        static void Main(string[] args)
        {
            example<int> ex = new example<int>(20);
            example<string> ex1 = new example<string>("Swati");
            example<double> ex2 = new example<double>(32.907);
            example<float> ex3 = new example<float>(3.6f);
            ex.Print();
            ex1.Print();
            ex2.Print();
            ex3.Print();
            Console.ReadKey();
        }
    }

    class example<t> //Generic class
    {
        t variable1;
        t variable2;
        public example(t check)
        {
            variable1 = check;
            variable2 = variable1;
        }

        public void Print()
        {
            Console.WriteLine("This is Variable1 {0}", variable1);
            Console.WriteLine("This is Variable2 {0}", variable2);
        }
    }

    //Custom Generic class
    
}
