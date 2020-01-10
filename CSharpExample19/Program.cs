using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpExample19
{
    public delegate double Calc(double x, double y);

    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator();
            //Calc calc1 = new Calc(calculator.Add);
            //Calc calc2 = new Calc(calculator.Sub);
            //Console.WriteLine(calc1(1, 2));
            //Console.WriteLine(calc2(1, 2));

            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            Logger logger = new Logger();
            Action<Product> log = new Action<Product>(logger.Log);

            IProductFactory pizzaFactory = new PizzaFactory();
            IProductFactory toyCarFactory = new ToyCarFactory();

            Box box1 = wrapFactory.WrapProduct(pizzaFactory, log);
            Box box2 = wrapFactory.WrapProduct(toyCarFactory, log);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);

            //Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            //Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            //Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Red };

            //Action action1 = new Action(stu1.DoHomework);
            //Action action2 = new Action(stu2.DoHomework);
            //Action action3 = new Action(stu3.DoHomework);

            //action1 += action2;
            //action1 += action3;
            //action1.Invoke();
            ////action1.BeginInvoke(null, null);

            //Task task1 = new Task(new Action(stu1.DoHomework));
            //Task task2 = new Task(new Action(stu2.DoHomework));
            //Task task3 = new Task(new Action(stu3.DoHomework));

            //task1.Start();
            //task2.Start();
            //task3.Start();


        }

        
    }

    //class Student
    //{
    //    public int ID { get; set; }
    //    public ConsoleColor PenColor { get; set; }

    //    public void DoHomework()
    //    {
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.ForegroundColor = this.PenColor;
    //            Console.WriteLine("Student {0} doing homework {1} hour(s).", this.ID, i);
    //            Thread.Sleep(1000);
    //        }
    //    }
    //}




    //class Calculator
    //{
    //    public double Add(double x, double y)
    //    {
    //        return x + y;
    //    }

    //    public double Sub(double x, double y)
    //    {
    //        return x - y;
    //    }

    //}

    interface IProductFactory
    {
        Product Make();
    }

    class PizzaFactory : IProductFactory
    {
        public Product Make()
        {
            return new Product() { Name = "Pizza", Price = 12 };
        }
    }

    class ToyCarFactory : IProductFactory
    {
        public Product Make()
        {
            return new Product() { Name = "Toy Car", Price = 100 };
        }
    }

    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("Product '{0}' created at {1}. Price is {2}.", product.Name, DateTime.UtcNow, product.Price);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WrapProduct(IProductFactory productFactory, Action<Product> logCallback)
        {
            Box box = new Box();
            Product product = productFactory.Make();
            if (product.Price > 50)
            {
                logCallback(product);
            }
            box.Product = product;
            return box;
        }
    }

    class ProductFactory
    {
        public Product MakePizza()
        {
            return new Product() { Name = "Pizza", Price = 12 };
        }

        public Product MakeToyCar()
        {
            return new Product() { Name = "Toy Car", Price = 100 };
        }
    }
}
