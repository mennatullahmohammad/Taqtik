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
    public partial class TeamStats : Form
    {
        Controller controllerObj = new Controller();
        private string _currentUsername;
        public TeamStats(string username)
        {
            InitializeComponent();
            _currentUsername = username; // Store it for use in datagrid view
        }

        private void TeamStats_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectTeamByUsername(_currentUsername);

            dataGridView_teamstats.DataSource = dt;
            dataGridView_teamstats.Refresh();
            if (dt != null && dt.Rows.Count > 0)
            {
                string teamName = dt.Rows[0]["name"].ToString(); //default team at row 0
                label_userteam.Text = teamName;
            }
            else
            {
                label_userteam.Text = "No Team Assigned";
            }
        }

        private void dataGridView_teamstats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_userteam_Click(object sender, EventArgs e)
        {

        }
    }
}
