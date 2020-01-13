using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpExample26
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Vehicle
    {
        private int speed;

        public virtual int Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public virtual void Run()
        {
            Console.WriteLine("I'm running.");
            speed = 100;
        }
    }

    class Car: Vehicle
    {
        private int _npm;

        public override int Speed
        {
            get { return _npm / 100; }
            set { _npm = value * 100; }
        }


        public override void Run()
        {
            Console.WriteLine("Car is running.");
        }
    }
}
