using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    class List_SortedList
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Programming ");
            list.Add("is fun");
            list.Add("C# list is Collection");
            Console.WriteLine("List Items are : ");
            foreach(var x in list)
            {
                Console.WriteLine(x);
            }
              
            List<string> list1 = new List<string>();
            list1.Add("Swati");
            list1.Add("Mehla");
            list.AddRange(list1);  //Add range 
            foreach(var x in list)
            {
                Console.WriteLine(x);
            }

            List<string> list2 = new List<string> { "ram", "raj", "gas" };//Another type of initia;ization
            foreach(var x in list2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(list2[1]); ; 
            list.Clear(); //Clear function
            foreach(var x in list)
            {
                Console.WriteLine(x);
            }

            //sorted list
            SortedList<int, string> slist = new SortedList<int, string>();
            slist.Add(10, "ten");
            slist.Add(4, "four");
            slist.Add(6, "six");
            slist.Add(2, "two");

            foreach (var check in slist)
            {
                Console.WriteLine("Key {0} : value {1}", check.Key, check.Value);
            }
            Console.ReadKey();
        }
    }
}
