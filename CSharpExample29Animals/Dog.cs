﻿using CSharpExample29BabyStrollerSDK;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Lib
{
    public class Dog: IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Wang!");
            }
        }
    }
}
