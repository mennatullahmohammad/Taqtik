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
    public partial class AddCompetition : Form
    {
        Controller controllerObj;

        public AddCompetition()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text.Trim();
            string country = textBox_country.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(country))
            {
                MessageBox.Show("Please enter both Name and Country.");
                return;
            }

            int result = controllerObj.InsertCompetition(name, country);

            if (result == 0)
            {
                MessageBox.Show("Failed to add competition.");
                return;
            }

            MessageBox.Show("Competition added successfully ✔");

            textBox_name.Clear();
            textBox_country.Clear();
        

        }

        private void label_country_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_year_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }
    }
}
