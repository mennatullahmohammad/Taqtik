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
    public partial class Team : Form
    {
        Controller controllerObj = new Controller();
        public Team()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllTeams();

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "team_id";

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "team_id";

        }

        private void button_teamstats_Click(object sender, EventArgs e)
        {
            TeamStats teamstats = new TeamStats();
            teamstats.Show();
        }

        private void button_playerstats_Click(object sender, EventArgs e)
        {
            PlayerStats playerstats = new PlayerStats();
            playerstats.Show();
        }

        private void Team_Load(object sender, EventArgs e)
        {

        }

        private void button_showmatch_Click(object sender, EventArgs e)
        {

        }

        private void button_showteam_Click(object sender, EventArgs e)
        {

        }
    }
}
