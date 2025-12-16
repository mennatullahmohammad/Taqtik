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
        public Team(string username)
        {
            InitializeComponent();
            _currentUsername = username;
        }

        private void button_teamstats_Click(object sender, EventArgs e)
        {
            TeamStats teamstats = new TeamStats(_currentUsername);
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

    }
}