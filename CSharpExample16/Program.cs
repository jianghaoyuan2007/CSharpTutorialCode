using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExample16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            IEnumerator enumator = intArray.GetEnumerator();
            while (enumator.MoveNext())
            {
                Console.WriteLine(enumator.Current);
            }
            Console.WriteLine("");
        }
    }
}
