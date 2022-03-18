using System;
using System.Windows.Forms;

namespace EventMyForm
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm myForm = new MyForm();
            //myForm.Click += myForm.FormClicked;
            //myForm.Click += new System.EventHandler(myForm.FormClicked);
            //myForm.Click += delegate (object sender, EventArgs e) { myForm.Text = DateTime.Now.ToString(); }
            //myForm.Click += (object sender, EventArgs e) => myForm.Text = DateTime.Now.ToString();
            myForm.Click += (sender, e) => myForm.Text = DateTime.Now.ToString();
            myForm.ShowDialog();
        }
    }

    class MyForm : Form
    {
        internal void FormClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
