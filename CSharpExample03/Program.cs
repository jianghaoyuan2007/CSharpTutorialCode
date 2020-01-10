using MyTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool;

namespace CSharpExample03
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.Add(1, 2));
            Console.WriteLine(c.Sub(2, 1));

            // 以 dll 的方式来引入并使用
            MyCalculator myCalculator = new MyCalculator();
            Console.WriteLine(myCalculator.Add(3, 4));
            Console.WriteLine(myCalculator.Sub(3, 4));
            Form form = new Form();
            form.ShowDialog();
        }
    }
}
