using System;
using System.Windows.Forms;

namespace EventForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            Controller controller = new Controller(form);
            form.ShowDialog();
        }
    }

    class Controller
    {
        private Form form;

        public Controller(Form form)
        {
            this.form = form ?? throw new ArgumentNullException(nameof(form));
            this.form.Click += FormClicked;
        }

        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
