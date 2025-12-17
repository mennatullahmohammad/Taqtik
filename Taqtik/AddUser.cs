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
    public partial class AddUser : Form
    {
        Controller controllerObj = new Controller();
        public AddUser()
        {
            InitializeComponent();
            comboBox_role.Items.Add("Admin");
            comboBox_role.Items.Add("DataEntry");
            comboBox_role.SelectedIndex = 0;
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

        private void button_add_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text;
            string confirmPassword = textBox_confirmpassword.Text;
            string role = comboBox_role.SelectedItem.ToString();

            if (username == "" || password == "" || role == "")
            {
                MessageBox.Show("Fill all fields");
                return;
            }
            if (textBox_password.Text == textBox_confirmpassword.Text)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                label_passworddoesntmatch.Visible = true;

            }
            int result = controllerObj.InsertUser(username, password, role, 0);

            if (result == -1)
            {
                MessageBox.Show("Username already exists.");
            }
            else if (result > 0)
            {
                MessageBox.Show("User added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add user.");
            }

        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
