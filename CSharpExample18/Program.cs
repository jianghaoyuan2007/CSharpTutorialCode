using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExample18
{
    class Program
    {
        static void Main(string[] args)
        {
            //int y = 1;
            //IWantSideEffect(ref y);
            //Console.WriteLine(y);

            //double x = 0;
            ////double.TryParse("123", out x);
            //DoubleParser.TryParse("123", out x);
            //Console.WriteLine(x);

            //Student stu = null;
            //bool result = StudentFactory.Create("Tim", 23, out stu);
            //if (result)
            //{
            //    Console.WriteLine("{0}-{1}", stu.Name, stu.Age);
            //}

            //var count = Count(1, 12);
            //Console.WriteLine(count);

            Console.WriteLine(123.333333.Round(2));
            Console.WriteLine("");

        }


        static void IWantSideEffect(ref int x)
        {
            x = x + 100;
        }

        static int Count(params int[] array)
        {
            return array.Length;
        }
    }

    static class DoubleExtension
    {
        public static double Round(this double input, int digits)
        {
            return Math.Round(input, digits);
        }
    }

    class DoubleParser
    {
        public static bool TryParse(string input, out double result)
        {
            try
            {
                result = double.Parse(input);
                return true;
            }
            catch (Exception)
            {

                result = 0;
                return false;
            }

        }
    }

    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class StudentFactory
    {
        public static bool Create(string stuName, int stuAge, out Student result)
        {
            result = null;
            if (string.IsNullOrEmpty(stuName))
            {
                return false;
            }
            if (stuAge < 20 && stuAge > 40)
            {
                return false;
            }
            result = new Student() { Name = stuName, Age = stuAge };
            return true;
        }
    }


}
