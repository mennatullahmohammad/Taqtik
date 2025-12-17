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
    public partial class Match : Form
    {
        Controller controllerObj = new Controller();
        private string un;
        private string hometeam;
        private string awayteam;
        private int matchId;
        public Match(string username, string ateam, int matchid)
        {
            InitializeComponent();
            un = username;
            DataTable dt = controllerObj.SelectTeamByUsername(un);
            string teamName = dt.Rows[0]["name"].ToString();
            hometeam = teamName;
            awayteam = ateam;
            matchId = matchid;
        }

        private void Match_Load(object sender, EventArgs e)
        {
            label_home.Text = hometeam;
            label_away.Text = awayteam;

            // Verify match exists - if matchId was passed incorrectly, try to find it
            if (matchId <= 0)
            {
                matchId = controllerObj.GetMatchId(hometeam, awayteam);
                if (matchId == -1)
                {
                    MessageBox.Show("Match not found between " + hometeam + " and " + awayteam,
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }

            // Match info
            DataTable matchInfo = controllerObj.GetMatchInfo(matchId);

            if (matchInfo == null || matchInfo.Rows.Count == 0)
            {
                MessageBox.Show("Match information not found for match ID: " + matchId,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int gameweek = Convert.ToInt32(matchInfo.Rows[0]["gameweek_id"]);
            string referee = matchInfo.Rows[0]["referee"].ToString();

            label1.Text = referee;
            label_GW.Text = gameweek.ToString();

            // Home team stats
            int homeShots = controllerObj.GetTeamStat(matchId, hometeam, "shots");
            int homegoals = controllerObj.GetTeamStat(matchId, hometeam, "goals");
            int homefouls = controllerObj.GetTeamStat(matchId, hometeam, "fouls");
            int homeoffsides = controllerObj.GetTeamStat(matchId, hometeam, "offsides");
            int homeyellowcards = controllerObj.GetTeamStat(matchId, hometeam, "yellowcards");
            int homeredcards = controllerObj.GetTeamStat(matchId, hometeam, "redcards");
            int homecorners = controllerObj.GetTeamStat(matchId, hometeam, "corners");
            int homepasses = controllerObj.GetTeamStat(matchId, hometeam, "passes");

            // Away team stats
            int awayShots = controllerObj.GetTeamStat(matchId, awayteam, "shots");
            int awaygoals = controllerObj.GetTeamStat(matchId, hometeam, "goals");
            int awayfouls = controllerObj.GetTeamStat(matchId, hometeam, "fouls");
            int awayoffsides = controllerObj.GetTeamStat(matchId, hometeam, "offsides");
            int awayyellowcards = controllerObj.GetTeamStat(matchId, hometeam, "yellowcards");
            int awayredcards = controllerObj.GetTeamStat(matchId, hometeam, "redcards");
            int awaycorners = controllerObj.GetTeamStat(matchId, hometeam, "corners");
            int awaypasses = controllerObj.GetTeamStat(matchId, hometeam, "passes");

            textBox_homeShots.Text = homeShots.ToString();
            textBox_awayShots.Text = awayShots.ToString();

            textBox_homeResult.Text = homegoals.ToString();
            textBox_awayResult.Text = awaygoals.ToString();

            textBox_homeFouls.Text = homefouls.ToString();
            textBox_awayFouls.Text = awayfouls.ToString();

            textBox_homeOffsides.Text = homeoffsides.ToString();
            textBox_awayOffsides.Text = awayoffsides.ToString();

            textBox_homeYellow.Text = homeyellowcards.ToString();
            textBox_awayYellow.Text = awayyellowcards.ToString();

            textBox_homeRed.Text = homeredcards.ToString();
            textBox_awayRed.Text = awayredcards.ToString();

            textBox_homeCorners.Text = homecorners.ToString();
            textBox_awayCorners.Text = awaycorners.ToString();

            textBox_homePasses.Text = homepasses.ToString();
            textBox_awayPasses.Text = awaypasses.ToString();


        }

        private void textBox_homeShots_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_possession_Click(object sender, EventArgs e)
        {

        }
    }
}
