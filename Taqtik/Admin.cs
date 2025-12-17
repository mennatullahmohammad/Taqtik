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
    public partial class Admin : Form
    {
        Controller ControllerObj;
        public Admin()
        {
            InitializeComponent();
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.SelectAllUsers();
            dataGridView_users.DataSource = dt;
            dataGridView_users.Refresh();

            DataTable dt2 = ControllerObj.SelectAllTeams();
            comboBox_chooseteam.DataSource = dt2;
            comboBox_chooseteam.DisplayMember = "name";
            comboBox_chooseteam.ValueMember = "team_id";
            DataTable dt3
        }

        private void button_adduser_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button_display_Click(object sender, EventArgs e)
        {
            if (comboBox_chooseteam.SelectedValue == null)
            {
                MessageBox.Show("Please select a team first.");
                return;
            }
            int teamId = Convert.ToInt32(comboBox_chooseteam.SelectedValue);
            TeamStats teamstats = new TeamStats(teamId);
            teamstats.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
