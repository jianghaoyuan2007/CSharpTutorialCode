using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpExample30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apple apple = new Apple() { Color = "Red" };
            //Book book = new Book() { Name = "New Book" };
            //Box<Apple> box1 = new Box<Apple>() { Cargo = apple };
            //Box<Book> box2 = new Box<Book>() { Cargo = book };
            //Console.WriteLine(box1.Cargo.Color);
            //Console.WriteLine(box2.Cargo.Name);

            //Student stu = new Student();
            //stu.ID = 101L;
            //stu.Name = "Stephen";
            //Console.WriteLine(stu.ID);
            //Console.WriteLine(stu.Name);

            //int[] a1 = { 1, 2, 3, 4, 5 };
            //int[] a2 = { 1, 2, 3, 4, 5 };
            //double[] b1 = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            //double[] b2 = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            //var result = Zip(a1, a2);
            //Console.WriteLine(string.Join(",", result));

            //Func<double, double, double> func1 = Add;
            //var result = func1(100.1, 200.2);
            //Console.WriteLine(result);

            //Func<double, double, double> func1 = (a, b) => { return a + b; };
            //var result = func1(100.1, 200.2);
            //Console.WriteLine(result);

            // 比特位用法
            //Person person = new Person() { Skill = Skill.Cook | Skill.Program, Name = "Stephen" };
            //Console.WriteLine((person.Skill & Skill.Cook)  == Skill.Cook);
            //Console.WriteLine((person.Skill & Skill.Program) == Skill.Program);

            Student stu = new Student() { ID = 101, Name = "Stephen" };
            stu.Speak();
        }

        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //static double Add(double a, double b)
        //{
        //    return a + b;
        //}

        //static T[] Zip<T>(T[] a, T[] b)
        //{
        //    T[] zipped = new T[a.Length + b.Length];
        //    int ai = 0, bi = 0, zi = 0;
        //    do
        //    {
        //        if (ai < a.Length)
        //        {
        //            zipped[zi++] = a[ai++];
        //        }
        //        if (bi < b.Length)
        //        {
        //            zipped[zi++] = b[bi++];
        //        }
        //    } while (ai < a.Length || bi < b.Length);
        //    return zipped;
        //}
    }

    //class Apple
    //{
    //    public string Color { get; set; }
    //}

    //class Book
    //{
    //    public string Name { get; set; }
    //}

    //class Box<T>
    //{
    //    public T Cargo { get; set; }
    //}

    //interface IUnique<TId>
    //{
    //    TId ID { get; set; }
    //}

    //class Student: IUnique<ulong>
    //{
    //    public ulong ID { get; set; }

    //    public string Name { get; set; }
    //}


    //class Person
    //{
    //    public string Name { get; set; }

    //    public Skill Skill { get; set; }
    //}
    //enum Skill
    //{
    //    Drive = 1,
    //    Cook = 1 << 1,
    //    Program = 1 << 2,
    //    Teach = 1 << 3,
    //}

    interface ISpeak
    {
        void Speak();
    }

    // 结构体类型不能继承，只能实现多个接口。不允许显示无参构造器。
    struct Student : ISpeak
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // 有参构造器
        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public void Speak()
        {
            Console.WriteLine("I'm a student.");
        }
    }
}
