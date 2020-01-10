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

namespace CSharpExample10
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Person p1 = new Person();
            //Person p2 = new Person();
            //p1.Name = "Deer";
            //p2.Name = "Deer's wife";
            ////List<Person> nation = Person.GetMarry(p1, p2);
            //List<Person> nation = p1 + p2;
            //foreach (var item in nation)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Type t = typeof(int);
            //Console.WriteLine(t.Namespace);
            //Console.WriteLine(t.FullName);
            //Console.WriteLine(t.Name);

            //int c = t.GetMethods().Length;
            //foreach (var item in t.GetMethods())
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Console.WriteLine(c);

            int c = default(int);
            Console.WriteLine(c);

            Window window = default(Window);
            Console.WriteLine(window == null);

            Level level = default(Level);
            Console.WriteLine(level);
        }
    }

    enum Level
    {
        Low = 1,
        Mid = 2,
        High = 3
    }


    class Person
    {
        public string Name;

        public static List<Person> operator + (Person p1, Person p2)
        // public static List<Person> GetMarry(Person p1, Person p2)
        {
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.Name = p1.Name + "&" + p2.Name + "'s child";
                people.Add(child);
            }
            return people;
        } 
    }
}
