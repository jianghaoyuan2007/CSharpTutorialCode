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

namespace CSharpExample08
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Calculator c = new Calculator();
            Console.WriteLine(c.GetCicleArea(10));
        }
    }

    class Calculator
    {
        public double GetCicleArea(double r)
        {
            return 3.14 * r * r;
        }

        public double GetCylinderVolume(double r, double h)
        {
            return GetCicleArea(r) * h;
        }

        public double GetConeVolume(double r, double h)
        {
            return GetCylinderVolume(r, h) / 3;
        }
    }

}
