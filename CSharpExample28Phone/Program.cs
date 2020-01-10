using System;

namespace CSharpExample28Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            new PhoneUser(new EricssonPhone()).UsePhone();
        }
    }

    class PhoneUser
    {
        private IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }
        public void UsePhone()
        {
            _phone.Dail();
            _phone.Send();
            _phone.Received();
            _phone.PickUp();
        }
    }

    interface IPhone
    {
        void Dail();
        void PickUp();
        void Send();
        void Received();
    }

    class NokiaPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Nokia calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is Tim!");
        }

        public void Received()
        {
            Console.WriteLine("Nokia message is ringing...");
        }

        public void Send()
        {
            Console.WriteLine("Hello");
        }
    }

    class EricssonPhone: IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Ericsson calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is Tim!");
        }

        public void Received()
        {
            Console.WriteLine("Ericsson message is ringing...");
        }

        public void Send()
        {
            Console.WriteLine("Hello");
        }
    }
}
