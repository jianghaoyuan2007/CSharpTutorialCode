using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpExample31
{
    delegate void MyDelegation();

    delegate int MyDelegation2(int a, int b);

    delegate T MyDelegation3<T>(T a, T b);

    class Program
    {
        static void Main(string[] args)
        {
            //MyDelegation delegation1 = new MyDelegation(M1);
            //Student stu = new Student();
            //delegation1 += stu.sayHello;
            //delegation1.Invoke();

            //MyDelegation2 delegation2 = new MyDelegation2(Add);
            //var result = delegation2.Invoke(1, 1);
            //Console.WriteLine(result);

            //MyDelegation3<double> mydele3 = new MyDelegation3<double>(Mult);
            //var result = mydele3.Invoke(2.2, 1.0);
            //Console.WriteLine(result);

            // 内置的委托
            //Action<string> act1 = new Action<string>(SayHello);
            //act1.Invoke("Stephen");

            //var func = new Func<double, double, double>(Mult);
            //Console.WriteLine(func.Invoke(3, 4));

            //Func<int, int, int> func = new Func<int, int, int>((a, b) => { return a + b; });
            //Console.WriteLine(func.Invoke(100, 200));

            //Func<int, int, int> func = (a, b) => { return a + b; };
            //Console.WriteLine(func.Invoke(100, 200));

            //func = new Func<int, int, int>((int x, int y) => { return x * y; });
            //Console.WriteLine(func.Invoke(3, 4));

            //DoSomeCalc<int>((a, b) => { return a * b; }, 100, 200);


        }

        static void DoSomeCalc<T>(Func<T, T, T> func, T x, T y)
        {
            T result = func(x, y);
            Console.WriteLine(result);
        }

        static void M1()
        {
            Console.WriteLine("M1 is a called.");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Mult(double x, double y)
        {
            return x * y;
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
    }

    class Student
    {
        public void sayHello()
        {
            Console.WriteLine("Hello, I'm a student.");
        }
    }
}
