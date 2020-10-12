using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Anonymous
{
    public delegate string GreetingDelegate(string name);

    public delegate int Addition_Delegate(int x, int y, int z);

    public delegate int Subtration_Delegate(int x, int y);

    class Anonymous
    {
        static void Main(string[] args)
        {
            //Definition Of Anonymous Delegate
            GreetingDelegate obj = delegate (string name)
              {
                  return "Hello" + name + "Godd Morning";
              };

            //Definition of Anonymous Delegate
            Addition_Delegate obj1 = delegate (int x, int y, int z)
              {
                  return (x + y + z);
              };

            //Definition Of Anonymous Delegate
            Subtration_Delegate obj2 = delegate (int x, int y)
              {
                  return (x - y);
              };

            //Instantiation of Delegates
            string str = obj.Invoke("Girls");
            int add_reault = obj1.Invoke(4, 7, 9);
            int sub_result = obj2.Invoke(20, 10);

            //print Value Of Results
            Console.WriteLine("this Is String : {0} ", str);
            Console.WriteLine("This IS Addition Result : {0} ", add_reault);
            Console.WriteLine("This is Subtraction Result : {0} ", sub_result);
            Console.ReadKey();

        }
    }
}
