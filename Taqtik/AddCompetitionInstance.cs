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
    public partial class AddCompetitionInstance : Form
    {
        Controller controllerObj;

        public AddCompetitionInstance()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt2 = controllerObj.SelectAllSeasons();
            DataTable dt3 = controllerObj.SelectAllCompetitons();

            comboBox_Season.DataSource = dt2;
            comboBox_Season.DisplayMember = "year";
            comboBox_Season.ValueMember = "season_id";

            comboBox_competition.DataSource = dt3;
            comboBox_competition.DisplayMember = "name";
            comboBox_competition.ValueMember = "competition_id";

        }

        private void comboBox_Season_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
        
            if (comboBox_Season.SelectedValue == null || comboBox_competition.SelectedValue == null)
            {
                MessageBox.Show("Please select Season and Competition.");
                return;
            }

            int seasonId = (int)comboBox_Season.SelectedValue;
            int compId = (int)comboBox_competition.SelectedValue;

            // parse numbers
            int relegation, teams;
            int? promotion = null;

            if (!string.IsNullOrWhiteSpace(textBox_promotion.Text))
            {
                if (!int.TryParse(textBox_promotion.Text.Trim(), out int promo))
                {
                    MessageBox.Show("Promotion must be a number (or leave empty).");
                    return;
                }
                promotion = promo;
            }

            if (!int.TryParse(textBox_relegation.Text.Trim(), out relegation))
            {
                MessageBox.Show("Relegation must be a number.");
                return;
            }

            if (!int.TryParse(textBox_noOfTeams.Text.Trim(), out teams))
            {
                MessageBox.Show("Number of teams must be a number.");
                return;
            }

            // prevent duplicates
            if (controllerObj.CompetitionInstanceExists(seasonId, compId))
            {
                MessageBox.Show("This Competition Instance already exists for that Season + Competition.");
                return;
            }

            int res = controllerObj.InsertCompetitionInstance(seasonId, compId, promotion, relegation, teams);

            if (res == 0)
            {
                MessageBox.Show("Failed to add Competition Instance.");
                return;
            }

            MessageBox.Show("Competition Instance added successfully ✔");
        

        }
    }
}
