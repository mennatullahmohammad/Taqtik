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
    public partial class AddTeamtoCompetition : Form
    {
        Controller controllerObj;

        public AddTeamtoCompetition()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectAllTeams();
            DataTable dt2 = controllerObj.SelectAllSeasons();
            DataTable dt3 = controllerObj.SelectAllCompetitons();

            comboBox_team.DataSource = dt;
            comboBox_team.DisplayMember = "name";
            comboBox_team.ValueMember = "team_id";

            comboBox_Season.DataSource = dt2;
            comboBox_Season.DisplayMember = "year";
            comboBox_Season.ValueMember = "season_id";

            comboBox_competition.DataSource = dt3;
            comboBox_competition.DisplayMember = "name";
            comboBox_competition.ValueMember = "competition_id";
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            if (comboBox_team.SelectedValue == null ||
                comboBox_Season.SelectedValue == null ||
                comboBox_competition.SelectedValue == null)
            {
                MessageBox.Show("Please select Team, Season, and Competition.");
                return;
            }

            int teamId = (int)comboBox_team.SelectedValue;
            int seasonId = (int)comboBox_Season.SelectedValue;
            int compId = (int)comboBox_competition.SelectedValue;

            int scid = controllerObj.GetSeasonCompetitionId(seasonId, compId);

            if (scid == -1)
            {
                MessageBox.Show("No Competition Instance exists for this Season + Competition.\nAdd Competition Instance first.");
                return;
            }

            if (controllerObj.TeamSeasonExists(teamId, scid))
            {
                MessageBox.Show("This team is already added to this competition instance.");
                return;
            }

            int res = controllerObj.InsertTeamSeason(teamId, scid);

            if (res == 0)
            {
                MessageBox.Show("Failed to add team to competition.");
                return;
            }

            MessageBox.Show("Team added successfully ✔");

        }
    }
}
