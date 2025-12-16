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
    public partial class AddMatch : Form
    {
        Controller controllerObj;
        bool formLoaded = false; 
        public AddMatch()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectAllTeams();
            DataTable dtt = controllerObj.SelectAllTeams();
            DataTable dt2 = controllerObj.SelectAllSeasons();
            DataTable dt3 = controllerObj.SelectAllCompetitons();
            DataTable dt4 = controllerObj.SelectAllReferees();

            comboBoxhometeam.DataSource = dt;
            comboBoxhometeam.DisplayMember = "name";
            comboBoxhometeam.ValueMember = "team_id";

            comboBoxawayteam.DataSource = dtt;
            comboBoxawayteam.DisplayMember = "name";
            comboBoxawayteam.ValueMember = "team_id";
            
            comboBoxseason.DataSource = dt2;
            comboBoxseason.DisplayMember = "year";
            comboBoxseason.ValueMember = "season_id";
            
            comboBoxcompetition.DataSource = dt3;
            comboBoxcompetition.DisplayMember = "name";
            comboBoxcompetition.ValueMember = "competition_id";
            
            comboBox_referee.DataSource = dt4;
            comboBox_referee.DisplayMember = "name";
            comboBox_referee.ValueMember = "referee_id";
            formLoaded = true;

        }

        private void button_addmatch_Click(object sender, EventArgs e)
        {
            // 1. Check selections
            if (comboBoxhometeam.SelectedValue == null ||
                comboBoxawayteam.SelectedValue == null ||
                comboBoxseason.SelectedValue == null ||
                comboBoxcompetition.SelectedValue == null ||
                comboBox_GW.SelectedValue == null ||
                comboBox_referee.SelectedValue == null)
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            int homeTeam = (int)comboBoxhometeam.SelectedValue;
            int awayTeam = (int)comboBoxawayteam.SelectedValue;

            // 2. Home ≠ Away
            if (homeTeam == awayTeam)
            {
                MessageBox.Show("Home team and Away team cannot be the same.");
                return;
            }

            // 3. Read remaining values
            int seasonId = (int)comboBoxseason.SelectedValue;
            int competitionId = (int)comboBoxcompetition.SelectedValue;
            int gameweekId = (int)comboBox_GW.SelectedValue;
            int refereeId = (int)comboBox_referee.SelectedValue;

            string venue = textBox1.Text.Trim();

            // TEMP confirmation (no DB yet)
            MessageBox.Show("Inputs are valid ✔\nReady to insert match.");
            int seasonCompetitionId = controllerObj.GetSeasonCompetitionId(seasonId, competitionId);

            if (seasonCompetitionId == -1)
            {
                MessageBox.Show(
                    "No Competition Instance exists for the selected Season and Competition.\n" +
                    "Please add it first."
                );
                return;
            }
            int matchId = controllerObj.InsertMatch(gameweekId,seasonCompetitionId,refereeId,venue);

            if (matchId == -1)
            {
                MessageBox.Show("Failed to insert match.");
                return;
            }

            int homeInsert = controllerObj.InsertMatchTeam(matchId, homeTeam, true);
            int awayInsert = controllerObj.InsertMatchTeam(matchId, awayTeam, false);

            if (homeInsert == 0 || awayInsert == 0)
            {
                MessageBox.Show("Match created but failed to assign teams.");
                return;
            }

            MessageBox.Show("Match added successfully ✔");


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxhometeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
    if (!formLoaded) return;
    if (comboBoxcompetition.SelectedIndex == -1) return;

            RefreshGameWeeks();
        }

        private void comboBox_referee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMatch_Load(object sender, EventArgs e)
        {

        }
        private void RefreshGameWeeks()
        {
            if (!formLoaded) return;

            if (comboBoxseason.SelectedValue == null || comboBoxcompetition.SelectedValue == null)
                return;

            int seasonId = (int)comboBoxseason.SelectedValue;
            int compId = (int)comboBoxcompetition.SelectedValue;

            int scid = controllerObj.GetSeasonCompetitionId(seasonId, compId);

            

            if (scid == -1)
            {
                comboBox_GW.DataSource = null;
                comboBox_GW.Items.Clear();
                return;
            }

            DataTable gw = controllerObj.SelectGameWeeksBySeasonCompetitionId(scid);

            comboBox_GW.DataSource = gw;
            comboBox_GW.DisplayMember = "gameweek_id";
            comboBox_GW.ValueMember = "gameweek_id";
            comboBox_GW.SelectedIndex = -1;
        }



        private void comboBoxseason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoaded) return;
            if (comboBoxseason.SelectedIndex == -1) return;
            RefreshGameWeeks();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
