using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpExample27
{
    class Program
    {
        static void Main(string[] args)
        {
            Vechicle v = new Car();
            v.Run();
        }
    }

    abstract class Vechicle
    {
        public void Stop()
        {
            Console.WriteLine("Stopped");
        }

        public void Fill()
        {
            Console.WriteLine("Pay and fill...");
        }

        public abstract void Run();
    }

    class Car : Vechicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }

    class Truck : Vechicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }
}
