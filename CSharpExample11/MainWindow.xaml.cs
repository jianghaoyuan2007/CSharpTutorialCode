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

namespace CSharpExample11
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //var x = 100; // 100L, 100D
            //x = "Error";
            //Console.WriteLine(x.GetType().Name);
            // 调用实例的初始化器
            //Form form = new Form() { Text = "Hello", FormBorderStyle=FormBorderStyle.SizableToolWindow };
            //form.ShowDialog();

            // new Form() { Text = "Hello" }.ShowDialog();

            //var person = new { Name = "Mr.Okay", Age = 34 };
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.Age);
            //Console.WriteLine(person.GetType().Name);

            //Student s1 = new Student();
            //s1.Report();
            //CSStudent s2 = new CSStudent();
            //s2.Report();

            //uint x = uint.MaxValue;
            //Console.WriteLine(x);

            //string binaryString = Convert.ToString(x, 2);
            //Console.WriteLine(binaryString);
            //checked
            //{
            //    try
            //    {
            //        //uint y = checked(x + 1);
            //        //uint y = unchecked(x + 1); // 默认模式
            //        uint y = x + 1;
            //        Console.WriteLine(y);
            //    }
            //    catch (OverflowException)
            //    {

            //        Console.WriteLine("There's overflow!");
            //    }
            //}

            //int x = sizeof(double);
            //Console.WriteLine(x);
            //unsafe
            //{
            //    int x = sizeof(Student); // 16 8 + 8
            //    Console.WriteLine(x);

            //    Student stud;
            //    stud.ID = 1;
            //    stud.Score = 99;
            //    Student* pStu = &stud;
            //    pStu->Score = 100;
            //    (*pStu).Score = 1000;
            //    Console.WriteLine(stud.Score);
            //}


            //int x = 12345678;
            //int y = ~x;
            //string xString = Convert.ToString(x, 2).PadLeft(32, '0');
            //string yString = Convert.ToString(y, 2).PadLeft(32, '0');
            //Console.WriteLine(xString);
            //Console.WriteLine(yString);

            // string.IsNullOrEmpty(str);

        }
    }

    struct Student
    {
        public int ID;
        public long Score;
    }





    //class Student
    //{
    //    public void Report()
    //    {
    //        Console.WriteLine("I am a student.");
    //    }
    //}

    //class CSStudent: Student
    //{
    //    new public void Report()
    //    {
    //        Console.WriteLine("I am a CS Student.");
    //    }
    //}
}
