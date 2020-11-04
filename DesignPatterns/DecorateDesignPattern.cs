using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class DecorateDesignPattern
    {
        static void Main(string[] args)
        {
            Car objCarAC = new WithAC();
            objCarAC.CarType();
            Console.WriteLine("\n");
            Car objCarSoundSystem = new WithSoundSystem();
            objCarSoundSystem.CarType();
            Console.WriteLine("\n");
            Car objCarAll = new WithSoundSystemAndAC();
            objCarAll.CarType();
            Console.ReadLine();
        }
    }
    public class Car
    {
        public virtual void CarType()
        {
            Console.WriteLine("Simple Car");
        }
    }
    public class WithAC : Car
    {
        public override void CarType()
        {
            //base.CarType();  
            Console.Write("AC Car");
        }
    }
    public class WithSoundSystemAndAC : WithAC
    {
        public override void CarType()
        {
            base.CarType();
            Console.WriteLine("with Sound system");
        }
    }
    public class WithSoundSystem : Car
    {
        public override void CarType()
        {
            //base.CarType();  
            Console.Write("Car with only sound system");
        }
    }
}
