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
    public partial class DataEntry : Form
    {
        private string _currentUsername;
        public DataEntry(string username)
        {
            InitializeComponent();
            _currentUsername = username;
            label_username.Text = _currentUsername;

        }

        private void button_addMatch_Click(object sender, EventArgs e)
        {
            AddMatch addMatchForm = new AddMatch();
            addMatchForm.Show();
            this.Hide();

        }

        private void button_addEvent_Click(object sender, EventArgs e)
        {
            AddEvent addEventForm = new AddEvent(_currentUsername);
            addEventForm.ShowDialog();
        }

        private void button_addPlayer_Click(object sender, EventArgs e)
        {
            AddPlayer addPlayerForm = new AddPlayer();
            addPlayerForm.ShowDialog();
        }

        private void buttonaddteam_Click(object sender, EventArgs e)
        {
            AddTeam addTeamForm = new AddTeam();
            addTeamForm.ShowDialog();
        }

        private void buttonaddseason_Click(object sender, EventArgs e)
        {
            AddSeason addSeasonForm = new AddSeason();
            addSeasonForm.ShowDialog();
        }

        private void buttoncompetition_Click(object sender, EventArgs e)
        {
            AddCompetition addCompetitionForm = new AddCompetition();
            addCompetitionForm.ShowDialog();
        }

        private void buttonreferee_Click(object sender, EventArgs e)
        {
            Add_Referee add_Refereeform = new Add_Referee();
            add_Refereeform.ShowDialog();
        }

        private void buttoncompinstance_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTeamtoCompetition addTeamtoCompetitionForm = new AddTeamtoCompetition();
            addTeamtoCompetitionForm.ShowDialog();
        }

        private void buttoncompinstance_Click_1(object sender, EventArgs e)
        {
            AddCompetitionInstance addCompetitionInstanceForm = new AddCompetitionInstance();
            addCompetitionInstanceForm.ShowDialog();
        }

        private void DataEntry_Load(object sender, EventArgs e)
        {

        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }
    }
}
