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
        private string teamname;
        Controller controllerObj = new Controller();
        public Team(string username)
        {
            InitializeComponent();
            _currentUsername = username;
            DataTable dt = controllerObj.SelectAllTeams();
            DataTable dt1 = controllerObj.SelectAllTeams();
            _currentUsername = username;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "team_id";
            comboBox1.DataSource = dt;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "team_id";
            comboBox2.DataSource = dt1;

            DataTable dt3 = controllerObj.SelectTeamByUsername(_currentUsername);
            teamId = Convert.ToInt32(dt3.Rows[0]["team_id"]);
            teamname = Convert.ToString(dt3.Rows[0]["name"]);
        }

        private void button_teamstats_Click(object sender, EventArgs e)
        {
            int idteam = controllerObj.GetTeamIdByName(comboBox2.Text);
            TeamStats teamstats = new TeamStats(idteam);
            teamstats.Show();
        }

        private void button_playerstats_Click(object sender, EventArgs e)
        {
            PlayerStats playerstats = new PlayerStats(teamId);
            playerstats.Show();
        }

        private void Team_Load(object sender, EventArgs e)
        {
            label1.Text = teamname;
        }

        private void button_showmatch_Click(object sender, EventArgs e)
        {
            int matchid = controllerObj.GetMatchId(teamname, comboBox1.Text);
            if (matchid > 0)
                {Match match = new Match(_currentUsername, comboBox1.Text, matchid);
                match.Show();
            }
            else
            {
                MessageBox.Show("Match not found.");
            }
        }

        private void button_showteam_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(controllerObj.FindTeam(comboBox2.Text, _currentUsername));

            if (result > 0)
            {
                TeamStats teamstat = new TeamStats(teamId);
                teamstat.Show();
            }
            else
            {
                subscription sub = new subscription(_currentUsername);
                sub.Show();
            }
        }
    }
}