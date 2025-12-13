using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taqtik
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpassword.Checked == true)
            {
                textBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
            }
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
        }
    }
}
