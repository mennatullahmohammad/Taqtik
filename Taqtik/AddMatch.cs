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

        }

        private void button_addSubs_Click(object sender, EventArgs e)
        {
            AddSubs addSubsForm = new AddSubs();
            addSubsForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxhometeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_referee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
