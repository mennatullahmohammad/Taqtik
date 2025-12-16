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
    public partial class PlayerStats : Form
    {
        Controller controllerObj = new Controller();
        public PlayerStats()
        {
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllPlayers();
            comboBox_players.DisplayMember = "name";
            comboBox_players.ValueMember = "player_id";
            comboBox_players.DataSource = dt;
        }

        private void PlayerStats_Load(object sender, EventArgs e)
        {
            
        }
        private void comboBox_players_SelectedIndexChanged(object sender, EventArgs e)
        {
            int player_id = Convert.ToInt32(comboBox_players.SelectedValue);
            DataTable dt = controllerObj.SelectGoals(player_id);
            textBox_goals.Text = textBox_goals.Text = dt.Rows[0][0].ToString();

            dt = controllerObj.Assists(player_id);
            textBox_assists.Text= dt.Rows[0][0].ToString();

            dt = controllerObj.RedCard(player_id);
            textBox_red.Text = dt.Rows[0][0].ToString();

            dt = controllerObj.YellowCard(player_id);
            textBox_yellow.Text = dt.Rows[0][0].ToString();

            dt = controllerObj.Shots(player_id);
            textBox_shots.Text = dt.Rows[0][0].ToString();

            dt = controllerObj.Passes(player_id);
            textBox_passes.Text = dt.Rows[0][0].ToString();

        }

        private void textBox_goals_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
