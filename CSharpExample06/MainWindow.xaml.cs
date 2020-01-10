using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CSharpExample06
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //dynamic myVar = 100;
            //Console.WriteLine(myVar);
            //myVar = "Hello";
            //Console.WriteLine(myVar);

            //Type myType = typeof(Window);
            //Console.WriteLine(myType.FullName);
            //Console.WriteLine(myType.BaseType.FullName);

            //PropertyInfo[] pInfos = myType.GetProperties();
            //foreach (var item in pInfos)
            //{
            //    Console.WriteLine(item);
            //}
            //MethodInfo[] mInfos = myType.GetMethods();
            //foreach (var item in mInfos)
            //{
            //    Console.WriteLine(item);
            //}

            //BadGuy b = new BadGuy();
            //b.BadMethod();

            //unsafe
            //{
            //    // System.StackOverflowException:“Exception_WasThrown”
            //    int* p = stackalloc int[9999999];
            //}

        }
        List<Window> winList;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            winList = new List<Window>();
            // Consume Memory
            for (int i = 0; i < 15000; i++)
            {
                winList.Add(new Window());
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // Resume Memory
            winList.Clear();
        }
    }

    class BadGuy
    {
        // System.StackOverflowException:“Exception_WasThrown”
        public void BadMethod()
        {
            int x = 100;
            this.BadMethod();
        }
    }
}
