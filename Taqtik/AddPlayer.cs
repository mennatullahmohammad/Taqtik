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
    public partial class AddPlayer : Form
    {
        Controller controllerObj;
        public AddPlayer()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text.Trim();
            string position = textBox_position.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            int? age = null;
            if (!string.IsNullOrWhiteSpace(textBox_age.Text))
            {
                if (!int.TryParse(textBox_age.Text.Trim(), out int a))
                {
                    MessageBox.Show("Age must be a number (or leave empty).");
                    return;
                }
                if (a < 10 || a > 60) 
                {
                    MessageBox.Show("Age seems invalid.");
                    return;
                }
                age = a;
            }

            int res = controllerObj.InsertPlayer(name, age, position);

            if (res == 0)
            {
                MessageBox.Show("Failed to add player.");
                return;
            }

            MessageBox.Show("Player added successfully ✔");
            textBox_name.Clear();
            textBox_age.Clear();
            textBox_position.Clear();
        }
    }
}
