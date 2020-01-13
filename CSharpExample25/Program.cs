using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpExample25
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Vehicle
    {
        public string Owner { get; set; }
        public Vehicle(string owner)
        {
            this.Owner = owner;
        }
    }

    class Car : Vehicle
    {
        public Car(string owner): base(owner)
        {

        }
    }

    
}
