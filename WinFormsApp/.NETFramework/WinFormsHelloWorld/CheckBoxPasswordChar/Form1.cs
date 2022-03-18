using System;
using System.Windows.Forms;

namespace CheckBoxPasswordChar {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e) {
            this.textBoxPassword.PasswordChar = 
                this.checkBoxShowPassword.Checked ? '\0' : '*';
        }

        private void checkBoxShowPassword_CheckStateChanged(object sender, EventArgs e) {

        }
    }
}
