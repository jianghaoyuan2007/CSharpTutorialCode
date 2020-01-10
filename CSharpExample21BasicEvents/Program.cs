using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace CSharpExample21BasicEvents
{
    class Program
    {
        static void Main(string[] args)
        {

            //Timer timer = new Timer();
            //timer.Interval = 1000;
            //Boy boy = new Boy();
            //timer.Elapsed += boy.Action;
            //Girl girl = new Girl();
            //timer.Elapsed += girl.Action;
            //timer.Start();
            //Console.ReadLine();

            //Form form = new Form();
            //Controller controller = new Controller(form);
            //form.ShowDialog();

            MyForm form = new MyForm();
            form.ShowDialog();
        }
    }

    //class Boy
    //{
    //    internal void Action(object sender, ElapsedEventArgs e)
    //    {
    //        Console.WriteLine("Jump");
    //    }
    //}

    //class Girl
    //{
    //    internal void Action(object sender, ElapsedEventArgs e)
    //    {
    //        Console.WriteLine("Sing!");
    //    }
    //}

    //class Controller
    //{
    //    private Form form;

    //    public Controller(Form form)
    //    {
    //        if (form != null)
    //        {
    //            this.form = form;
    //            this.form.Click += this.FormClicked;
    //        }
    //    }

    //    private void FormClicked(object sender, EventArgs e)
    //    {
    //        this.form.Text = DateTime.Now.ToString();
    //    }
    //}

    class MyForm: Form
    {
        private TextBox textBox;
        private Button button;

        public MyForm()
        {
            this.textBox = new TextBox();
            this.button = new Button();
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.button.Click += this.ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello WorldHello WorldHello WorldHello WorldHello World";
        }
    }
}
