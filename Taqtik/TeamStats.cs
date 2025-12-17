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
            _currentUsername = username;
        }
        private bool openedByAdmin = false;
        private int selectedTeamId;
        public TeamStats(int teamId)
        {
            InitializeComponent();
            selectedTeamId = teamId;
            openedByAdmin = true;
        }

        private void TeamStats_Load(object sender, EventArgs e)
        {
            DataTable dt;

            if (openedByAdmin)
            {
                // Admin opened the form → use teamId
                dt = controllerObj.GetTeamStatsByTeamId(selectedTeamId);

                if (dt != null && dt.Rows.Count > 0)
                {
                    label_userteam.Text = dt.Rows[0]["TeamName"].ToString();
                }
                else
                {
                    label_userteam.Text = "No Data Found";
                }
            }
            else
            {
                // User opened the form → use username (original behavior)
                dt = controllerObj.SelectTeamByUsername(_currentUsername);


                if (dt != null && dt.Rows.Count > 0)
                {
                    string teamName = dt.Rows[0]["name"].ToString(); //default row 0
                    label_userteam.Text = teamName;

                    DataTable statsTable = controllerObj.GetTeamStats(_currentUsername);
                    dataGridView_teamstats.DataSource = statsTable;
                    dataGridView_teamstats.Refresh();
                }
                else
                {
                    label_userteam.Text = "No Team Assigned";
                }
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
