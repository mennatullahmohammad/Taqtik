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
    public partial class AddSeason : Form
    {
        Controller controllerObj;

        public AddSeason()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void button_add_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox_year.Text.Trim(), out int year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            if (year < 1900 || year > 2100)   // sanity check
            {
                MessageBox.Show("Year out of valid range.");
                return;
            }

            if (controllerObj.SeasonExists(year))
            {
                MessageBox.Show("This season already exists.");
                return;
            }

            int res = controllerObj.InsertSeason(year);

            if (res == 0)
            {
                MessageBox.Show("Failed to add season.");
                return;
            }

            MessageBox.Show("Season added successfully ✔");
            textBox_year.Clear();
        }
    }
}
