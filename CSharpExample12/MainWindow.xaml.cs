using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharpExample12
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //double x = Convert.ToDouble("1.1");
            //double y = Convert.ToDouble("2.2");
            //double x = double.Parse("1.1");
            //double y = double.Parse("2.2");
            //double result = x + y;
            //Console.WriteLine(result);

            //Stone stone = new Stone();
            //stone.Age = 5000;
            //Monkey wukongSun = stone;   // 隐式类型转换
            ////Monkey wukongSun = (Monkey)stone;   // 显示类型转换
            //Console.WriteLine(wukongSun.Age);

            //double x = -5.0;
            //double y = 0;
            //double z = x / y;
            //double a = double.PositiveInfinity;
            //double b = double.NegativeInfinity;
            //double c = a / b;
            //Console.WriteLine(c);

            //Stone s = new Stone();
            //var result = s is Stone; // 继承也可以为真
            //Console.WriteLine(result.GetType().FullName);
            //Console.WriteLine(result);

            object o = new Stone();
            Stone s = o as Stone;
            if (s != null)
            {
                Console.WriteLine(s);
            }

            //Nullable<int> x = null;
            int? x = null;
            int result = x ?? 12;
            x = 100;
            Console.WriteLine(x);
            Console.WriteLine(x.HasValue);

        }
    }

    class Stone
    {
        public int Age;
        // 显示类型转换
        public static implicit operator Monkey(Stone stone)
        //// 显示类型转换
        //public static explicit operator Monkey(Stone stone)
        {
            Monkey m = new Monkey();
            m.Age = stone.Age / 500;
            return m;
        }
    }

    class Monkey
    {
        public int Age;
    }
}
