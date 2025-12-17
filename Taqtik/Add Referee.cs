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
    public partial class Add_Referee : Form
    {
        Controller controllerObj;

        public Add_Referee()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void Add_Referee_Load(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text.Trim();
            string country = textBox_country.Text.Trim();

            int ageValue;
            int? age = null;

            if (!string.IsNullOrWhiteSpace(textBox_age.Text))
            {
                if (!int.TryParse(textBox_age.Text.Trim(), out ageValue))
                {
                    MessageBox.Show("Age must be a number.");
                    return;
                }
                if (ageValue < 10 || ageValue > 100) // optional sanity check
                {
                    MessageBox.Show("Age seems invalid.");
                    return;
                }
                age = ageValue;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            int result = controllerObj.InsertReferee(name, age, country);

            if (result == 0)
            {
                MessageBox.Show("Failed to add referee.");
                return;
            }

            MessageBox.Show("Referee added successfully ✔");

            // optional:
            textBox_name.Clear();
            textBox_age.Clear();
            textBox_country.Clear();
        }
    }
}
