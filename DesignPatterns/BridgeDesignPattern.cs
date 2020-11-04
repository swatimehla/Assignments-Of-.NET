using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    class BridgeDesignPattern
    {
        static void Main(string[] args)
        {
            Bridge br = new Bridge();
            Node_A a = new Node_A();
            Node_B b = new Node_B();
            br.ReachTo(a); //Reach to Node_A  
            br.ReachTo(b); //Reach to Node_B  
            Console.ReadLine();
        }
    }


    public interface Inode
    {
        void Reach();
    }
    class Node_A : Inode
    {
        public void Reach()
        {
            Console.WriteLine("Rreached to node A");
        }
    }
    class Node_B : Inode
    {
        public void Reach()
        {
            Console.WriteLine("Rreached to node B");
        }
    }
    class Bridge
    {
        public void ReachTo(Inode obj)
        {
            obj.Reach();
        }
    }

}

