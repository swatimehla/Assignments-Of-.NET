using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class SingletonDesignPattern
    {

        static void Main(string[] args)
        {
            MySingleton object1 = MySingleton.sachin;
            object1.check();
            Console.ReadKey();
        }
    }
    public class MySingleton
    {
        private static readonly object find = new object();
        private static MySingleton instance = null;

        public static MySingleton sachin
        {
            get
            {
                lock (find)
                {
                    if (instance == null)
                    {
                        instance = new MySingleton();
                        return instance;
                    }
                    return instance;
                }
            }

          

        }
        public void check()
        {
            Console.Write("Singlton Class is Working");
        }
    }
}
