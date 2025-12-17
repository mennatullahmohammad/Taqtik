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

    public partial class TransferPlayer : Form
    {
        Controller controllerObj;
        int seasonCompetitionId = 1;


        public TransferPlayer()
        {
            InitializeComponent();
            controllerObj = new Controller();

            var dtP = controllerObj.SelectAllPlayers2();
            comboBox_player.DataSource = dtP;
            comboBox_player.DisplayMember = "name";
            comboBox_player.ValueMember = "player_id";
            comboBox_player.SelectedIndex = -1;

            var dtT = controllerObj.SelectAllTeams();
            comboBox_toTeam.DataSource = dtT;
            comboBox_toTeam.DisplayMember = "name";
            comboBox_toTeam.ValueMember = "team_id";
            comboBox_toTeam.SelectedIndex = -1;
        }

        private void button_transfer_Click(object sender, EventArgs e)
        {
            if (comboBox_player.SelectedValue == null || comboBox_toTeam.SelectedValue == null)
            {
                MessageBox.Show("Please select Player and To Team.");
                return;
            }

            int playerId = (int)comboBox_player.SelectedValue;
            int teamId = (int)comboBox_toTeam.SelectedValue;

            int teamSeasonId = controllerObj.GetOrCreateTeamSeasonId(teamId, seasonCompetitionId);
            if (teamSeasonId == -1)
            {
                MessageBox.Show("Failed to prepare TeamSeason for this team.");
                return;
            }

            int res = controllerObj.UpsertPlayerTeamInSeasonCompetition(playerId, teamSeasonId, seasonCompetitionId);

            if (res == 0)
            {
                MessageBox.Show("Transfer failed.");
                return;
            }

            MessageBox.Show("Transfer done ✔");
        }
    }
}
