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
    public partial class subscription : Form
    {
        Controller controllerObj = new Controller();
        private string currUsername;
        public subscription(string user)
        {
            InitializeComponent();

            DataTable dt = controllerObj.SelectAllTeams();

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "team_id";

            currUsername = user;
        }

        private void subscription_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.AddTeam(currUsername, comboBox1.Text);

            if (result > 0)
            {
                MessageBox.Show("Team Successfully added!");
            }
            else if (result < 0)
            {
                MessageBox.Show("Team already exists.");
            }
        }
    }
}
