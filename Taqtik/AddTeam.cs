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
    public partial class AddTeam : Form
    {
        Controller controllerObj;
        public AddTeam()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text.Trim();
            string country = textBox_country.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            int? yearFounded = null;
            if (!string.IsNullOrWhiteSpace(textBox_year.Text))
            {
                if (!int.TryParse(textBox_year.Text.Trim(), out int y))
                {
                    MessageBox.Show("Year Founded must be a number (or leave empty).");
                    return;
                }
                if (y < 1800 || y > 2100) // optional sanity
                {
                    MessageBox.Show("Year Founded seems invalid.");
                    return;
                }
                yearFounded = y;
            }

            int res = controllerObj.InsertTeam(name, country, yearFounded);

            if (res == 0)
            {
                MessageBox.Show("Failed to add team.");
                return;
            }

            MessageBox.Show("Team added successfully ✔");
            textBox_name.Clear();
            textBox_country.Clear();
            textBox_year.Clear();
        }
    }
}
