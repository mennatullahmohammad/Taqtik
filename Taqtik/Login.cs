using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taqtik
{
    public partial class Login : Form
    {

        Controller controllerObj=new Controller();
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
            string username = textBox_username.Text.Trim();
            string password= textBox_password.Text.Trim();
            int count = controllerObj.CheckLogin(username, password);
            if (count == 0) {
                MessageBox.Show("Username or Password incorrect.");
            }
            else if (count == 1) {
                //go to team form
                Team team = new Team();
                team.Show();
            }
            else
            {
                MessageBox.Show("Unexpected Error Occured");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
