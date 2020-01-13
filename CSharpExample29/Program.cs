using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace CSharpExample29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Driver driver = new Driver(new Car());
            //driver.Run();

            //Driver driver = new Driver(new LightTank());
            //driver.Run();

            //int[] nums1 = { 1, 2, 3, 4, 5};
            //ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5};
            //Console.WriteLine(Sum(nums1));
            //Console.WriteLine(Sum(nums2));

            //IKiller wk = new WarmKiller();
            //wk.Kill();

            //ITank tank = new LightTank();
            //var t = tank.GetType();
            //object o = Activator.CreateInstance(t);
            //MethodInfo fireMi = t.GetMethod("Fire");
            //MethodInfo runMi = t.GetMethod("Run");
            //fireMi.Invoke(o, null);
            //runMi.Invoke(o, null);

            //var sc = new ServiceCollection();
            //sc.AddScoped(typeof(ITank), typeof(LightTank));
            //sc.AddScoped(typeof(IVehicle), typeof(Car));
            //sc.AddScoped<Driver>();
            //var sp = sc.BuildServiceProvider();
            //// 
            //var driver = sp.GetService<Driver>();
            //driver.Run();




        }

        //static int Sum(IEnumerable collection)
        //{
        //    int count = 0;
        //    foreach (var item in collection)
        //    {
        //        count += (int)item;
        //    }
        //    return count;
        //}
    }

    //interface IGentleman
    //{
    //    void Love();
    //}

    //interface IKiller
    //{
    //    void Kill();
    //}

    //class WarmKiller : IGentleman, IKiller
    //{
    //    public void Love()
    //    {
    //        Console.WriteLine("I will love you forever...");
    //    }

    //    void IKiller.Kill()
    //    {
    //        Console.WriteLine("Let me kill the enemy...");
    //    }
    //}

    //class ReadOnlyCollection : IEnumerable
    //{
    //    private int[] _array;

    //    public ReadOnlyCollection(int[] array)
    //    {
    //        _array = array;
    //    }

    //    public IEnumerator GetEnumerator()
    //    {
    //        return new Enumerator(this);
    //    }

    //    public class Enumerator : IEnumerator
    //    {
    //        private ReadOnlyCollection _collection;
    //        private int _head;

    //        public Enumerator(ReadOnlyCollection collection)
    //        {
    //            _collection = collection;
    //        }
    //        public object Current {
    //            get {
    //                object o = _collection._array[_head];
    //                return o;
    //            }
    //        }

    //        public bool MoveNext()
    //        {
    //            if (++_head < _collection._array.Length)
    //            {
    //                return true;
    //            }
    //            return false;
    //        }

    //        public void Reset()
    //        {
    //            _head = -1;
    //        }
    //    }
    //}

        interface IWeapon
        {
            void Fire();
        }

        interface IVehicle
        {
            void Run();
        }

        interface ITank : IVehicle, IWeapon
        {

        }

        class Driver
        {
            private IVehicle _vehicle;
            public Driver(IVehicle vehicle)
            {
                _vehicle = vehicle;
            }

            public void Run()
            {
                _vehicle.Run();
            }
        }

        class Car : IVehicle
        {
            public void Run()
            {
                Console.WriteLine("Car is running.");
            }
        }

        class LightTank : ITank
        {
            public void Fire()
            {
                Console.WriteLine("Boom!");
            }

            public void Run()
            {
                Console.WriteLine("Ka - ka - ka....");
            }
        }

}
