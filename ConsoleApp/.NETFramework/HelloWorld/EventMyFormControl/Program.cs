using System;
using System.Windows.Forms;

namespace EventMyFormControl
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm myForm = new MyForm();
            myForm.ShowDialog();
        }
    }

    class MyForm : Form
    {
        private TextBox textBox;
        private Button button;

        public MyForm()
        {
            this.textBox = new TextBox();
            this.button = new Button();
            this.button.Text = "Say Hello";
            this.button.Top = 30;

            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button);

            this.button.Click += this.ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello World!";
        }
    }
}
