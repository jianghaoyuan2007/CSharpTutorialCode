﻿using System;

namespace CSharpExample28Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerSupply power = new PowerSupply();
            DeskFan fan = new DeskFan(power);
            Console.WriteLine(fan.Work());
        }
    }

    public interface IPowerSupply
    {
        int GetPower();
    }

    public class PowerSupply: IPowerSupply
    {
        public int GetPower()
        {
            return 100;
        }
    }

    public class DeskFan 
    {
        private IPowerSupply _powerSupply;
        public DeskFan(IPowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
        }

        public string Work()
        {
            int power = _powerSupply.GetPower();
            if (power <= 0)
            {
                return "Won't work.";
            } else if (power < 100)
            {
                return "Slow";
            }
            else if (power < 200)
            {
                return "Work fine!";
            } else
            {
                return "Warning!";
            }
        }
    }

}
