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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void checkBox_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpassword.Checked == true)
            {
                textBox_password.UseSystemPasswordChar = false;
                textBox_confirmpassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
                textBox_confirmpassword.UseSystemPasswordChar = true;
            }
        }

        private void button_signup_Click(object sender, EventArgs e)
        {



            if(textBox_password.Text==textBox_confirmpassword.Text)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                label_passworddoesntmatch.Visible = true;

            }
        }
    }
}
