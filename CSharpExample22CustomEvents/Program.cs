using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpExample22CustomEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
            customer.PayTheBill();
        }
    }

    public class OrderEventArgs: EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

    public class Customer
    {
        private OrderEventHandler orderEventHandler;

        public event OrderEventHandler Order
        {
            add
            {
                this.orderEventHandler += value;
            }
            remove
            {
                this.orderEventHandler -= value;
            }
        }

        public double Bill { get; set; }

        public void PayTheBill()
        {
            Console.WriteLine("I will pay ${0}.", this.Bill);
        }

        public void Think()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Let me think ...");
                Thread.Sleep(1000);
            }
            this.OnOrderEventHandler("Kongpao Chicken.", "large");
        }

        public void Action()
        {
            this.Think();
        }

        protected void OnOrderEventHandler(string dishName, string size)
        {
            if (this.orderEventHandler != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = dishName;
                e.Size =size;
                this.orderEventHandler.Invoke(this, e);
            }
        }
    }

    public class Waiter
    {
        internal void Action(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine("I will serve you the dish - {0}.", e.DishName);
            double price = 10;

        }
    }
}
