using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharpExample07
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Type myType = typeof(Window);
            //Console.WriteLine(myType.FullName);
            //Console.WriteLine(myType.IsClass);

            //Form f = new Form();
            //f.WindowState = FormWindowState.Maximized;
            //f.ShowDialog();

            //int[] array = new int[100];
            //array[99] = 100; 

            //int a; // 声明变量
            //int b;
            //a = 1;
            //b = 2;
            //int c = a + b;

            //short s = -1000;
            //string str = Convert.ToString(s, 2);
            //Console.WriteLine(str) ;

            int x = 100;
            object obj;
            obj = x; // Boxing
            int y = (int)obj; // Unboxing
        }
    }

    //class Student
    //{
    //    public static int Amount;
    //    public int Age;
    //    public string Name;

    //    public double Add(ref double a, out double b)
    //    {
    //        double result = a;
    //        b = 1;
    //        return result;
    //    }
    //}

     // 在堆内存中的分布
    class Student
    {
        uint ID;
        ushort Score;
    }
}
