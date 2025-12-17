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
    public partial class AddEvent : Form
    {
        Controller controllerObj;
        int currentUserId;
        public AddEvent(int userId=1)
        {
            InitializeComponent();
            controllerObj = new Controller();
            currentUserId = userId;

           
            DataTable dtPlayers = controllerObj.SelectAllPlayers();
            comboBox_player.DataSource = dtPlayers;
            comboBox_player.DisplayMember = "name";
            comboBox_player.ValueMember = "player_id";
            comboBox_player.SelectedIndex = -1;

            DataTable dtTypes = controllerObj.SelectAllEventTypes();
            comboBox_event.DataSource = dtTypes;
            comboBox_event.DisplayMember = "name";
            comboBox_event.ValueMember = "event_type_id";
            comboBox_event.SelectedIndex = -1;

            
            DataTable dtMatches = controllerObj.SelectMatchesForCombo();
            comboBox_match.DataSource = dtMatches;
            comboBox_match.DisplayMember = "display_text";
            comboBox_match.ValueMember = "match_id";
            comboBox_match.SelectedIndex = -1;

        }

        private void Add_Event_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (comboBox_player.SelectedValue == null ||
      comboBox_event.SelectedValue == null ||
      comboBox_match.SelectedValue == null)
            {
                MessageBox.Show("Please select Player, Event type, and Match.");
                return;
            }

            if (!int.TryParse(textBox_min.Text.Trim(), out int minute) || minute < 0 || minute > 130)
            {
                MessageBox.Show("Minute must be a valid number (0-120).");
                return;
            }

            if (!int.TryParse(textBox_sec.Text.Trim(), out int second) || second < 0 || second > 59)
            {
                MessageBox.Show("Second must be a valid number (0-59).");
                return;
            }

            int playerId = (int)comboBox_player.SelectedValue;
            int eventTypeId = (int)comboBox_event.SelectedValue;
            int matchId = (int)comboBox_match.SelectedValue;

            int res = controllerObj.InsertEvent(matchId, eventTypeId, playerId, minute, second, currentUserId);

            if (res == 0)
            {
                MessageBox.Show("Failed to add event.");
                return;
            }

            MessageBox.Show("Event added successfully ✔");
            textBox_min.Clear();
            textBox_sec.Clear();
        }
    }
}
