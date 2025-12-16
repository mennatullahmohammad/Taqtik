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
        Controller controllerObj = new Controller();
        public SignUp()
        {
            InitializeComponent();

            DataTable dt = controllerObj.SelectAllTeams();

            comboBox_team.DataSource = dt;
            comboBox_team.DisplayMember = "name";
            comboBox_team.ValueMember = "team_id";
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

            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else if (textBox_password.Text == textBox_confirmpassword.Text)
            {

                string role = "Analyst";
                int teamId = Convert.ToInt32(comboBox_team.SelectedValue);
                int result = controllerObj.InsertUser(textBox_username.Text, textBox_password.Text, role, teamId);
                if (result > 0)
                {
                    label_passworddoesntmatch.Visible = false;
                    MessageBox.Show("Signup Successful!");
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else if (result < 0) {
                    MessageBox.Show("Username is taken");
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match");

            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_team_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
