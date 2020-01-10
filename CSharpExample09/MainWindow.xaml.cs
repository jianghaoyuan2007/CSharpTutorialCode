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

namespace CSharpExample09
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Student stu = new Student(2, "Mr.Okay");
            //Console.WriteLine(stu.ID);
            //Console.WriteLine(stu.Name) ;

            Calculator c = new Calculator();
            Console.WriteLine(c.Add(100D, 200D));
            Console.WriteLine(c.Add(100, 200)); ;

        }
    }

    class Student
    {
        public int ID;
        public string Name;
        
        //public Student()
        //{
        //    this.ID = 1;
        //    this.Name = "No name.";
        //}

        public Student(int initID, string initName)
        {
            this.ID = initID;
            this.Name = initName;
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
