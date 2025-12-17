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
        private string _currentUsername;
        private int teamId;
        Controller controllerObj = new Controller();
        public Team(string username)
        {
            InitializeComponent();
            _currentUsername= username;
            DataTable dt= controllerObj.SelectTeamByUsername(_currentUsername);
            teamId = Convert.ToInt32(dt.Rows[0]["team_id"]);
        }

        private void button_teamstats_Click(object sender, EventArgs e)
        {
            TeamStats teamstats = new TeamStats(_currentUsername);
            teamstats.Show();
        }

        private void button_playerstats_Click(object sender, EventArgs e)
        {
            PlayerStats playerstats = new PlayerStats(teamId);
            playerstats.Show();
        }

        private void Team_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
