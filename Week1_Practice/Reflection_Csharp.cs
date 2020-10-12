using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_CSharp
{
    class Reflection_Csharp
    {
        static void Main(string[] args)
        {
            Type t = typeof(string);
            Console.WriteLine("Name : {0} ", t.Name);
            Console.WriteLine("Full Nmae : {0}", t.FullName);
            Console.WriteLine("NameSpace : {0}", t.Namespace);
            Console.WriteLine("BaseTypes : {0}", t.BaseType);

            int i = 34;
            System.Type type = i.GetType();
            System.Console.WriteLine(type);
            Console.ReadKey();
        }
    }
}
