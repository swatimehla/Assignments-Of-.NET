using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CompositeDesignPattern
{
    interface IDraw
    {
        void Draw();
    }
    class Circle : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("I am Circl");
        }
    }
    class Square : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("I am Square");
        }
    }
    class Oval : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("I am Oval");
        }
    }
    class CompositeDesignPattern
    {
        static void Main(string[] args)
        {
            ArrayList objList = new ArrayList();
            IDraw objcircl = new Circle();
            IDraw objSquare = new Square();
            IDraw objOval = new Oval();
            objList.Add(objcircl);
            objList.Add(objSquare);
            objList.Add(objOval);
            foreach (IDraw obj in objList)
            {
                obj.Draw();
            }
            Console.ReadLine();
        }

    }
}
