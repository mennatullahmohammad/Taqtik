using System;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;
using Taqtik;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Taqtik
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public int CheckLogin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE name = '" + username + "' AND password_hash = '" + password + "';";

            return (int)dbMan.ExecuteScalar(query);
        }
        public int InsertUser(string name, string password, string role, int teamId)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE name = '" + name  + "';";
            int count = (int)dbMan.ExecuteScalar(query);
            if (count > 0)
            {
                return -1;
            }
            else
            {
                string queryUser = "INSERT INTO Users (name, password_hash, role) " +
                           "VALUES ('" + name + "','" + password + "','" + role + "'); " +
                           "SELECT SCOPE_IDENTITY();";

                object result = dbMan.ExecuteScalar(queryUser);

                if (result != null)
                {
                    int newUserId = Convert.ToInt32(result);
                    string queryAccess = "INSERT INTO UserTeamAccess (user_id, team_id) " +
                                         "VALUES (" + newUserId + ", " + teamId + ");";
                    return dbMan.ExecuteNonQuery(queryAccess);
                }
            }
            return 0; 
        }

        public int AddTeam(string team, string usern)
        {
            string queryUser = "SELECT user_id FROM Users WHERE name = '" + usern + "';";
            string queryTeam = "SELECT team_id FROM Team WHERE name = '" + team + "';";

            object result = dbMan.ExecuteScalar(queryUser);
            object result2 = dbMan.ExecuteScalar(queryTeam);

            if (result != null && result2 != null)
            {

                int UserId = Convert.ToInt32(result);
                int teamId = Convert.ToInt32(result2);

                string queryAccess = "INSERT INTO UserTeamAccess (user_id, team_id) " +
                                     "VALUES (" + UserId + ", " + teamId + ");";
                return dbMan.ExecuteNonQuery(queryAccess);
            }
            return 0;
        }

        public int FindTeam(string team, string usern)
        {
            string queryUser = "SELECT user_id FROM Users WHERE name = '" + usern + "';";
            string queryTeam = "SELECT team_id FROM Team WHERE name = '" + team + "';";

            object result = dbMan.ExecuteScalar(queryUser);
            object result2 = dbMan.ExecuteScalar(queryTeam);

            if (result == null || result2 == null)
            {
                return 0;
            }

            int UserId = Convert.ToInt32(result);
            int teamId = Convert.ToInt32(result2);
            string queryTeamAccess = "SELECT COUNT(*) FROM UserTeamAccess WHERE user_id = " + UserId + " AND team_id = " + teamId + ";";
            int count = Convert.ToInt32(dbMan.ExecuteScalar(queryTeamAccess));
            return count;
        }

        public DataTable SelectAllTeams()
        {
            string query = "SELECT team_id, name FROM Team;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllSeasons()
        {
            string query = "SELECT season_id, year FROM Season;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllCompetitons()
        {
            string query = "SELECT competition_id, name FROM Competition;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllReferees()
        {
            string query = "SELECT referee_id, name FROM Referee;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllPlayers()
        {
            string query = "SELECT player_id,name FROM Player;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectTeamByUsername(string username)
        {
            string query = "SELECT T.team_id, T.name, T.country, T.year_founded " +
                           "FROM Team T " +
                           "JOIN UserTeamAccess A ON T.team_id = A.team_id " +
                           "JOIN Users U ON U.user_id = A.user_id " +
                           "WHERE U.name = '" + username + "';";

            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectRoleByUsername(string username)
        {
            string query = "SELECT role FROM Users WHERE name= '" + username + "'; ";

            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectGoals(int playerid)
        {
            string query = "SELECT COUNT(*) FROM Event E " +
                "JOIN EventType ET ON E.event_type_id = ET.event_type_id " +
                "WHERE E.player_id = " + playerid + " AND ET.name = 'Goal'";
            return dbMan.ExecuteReader(query); 
        }
        public DataTable SelectGameWeeks(int seasonId, int competitionId)
        {
            string query =
                "SELECT gw.gameweek_id " +
                "FROM GameWeek gw " +
                "INNER JOIN CompetitionInstance ci ON ci.season_competition_id = gw.season_competition_id " +
                "WHERE ci.season_id = " + seasonId + " " +
                "AND ci.competition_id = " + competitionId + " " +
                "ORDER BY gw.gameweek_id;";

            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectGameWeeksBySeasonCompetitionId(int seasonCompetitionId)
        {
            string query =
                "SELECT gameweek_id " +
                "FROM GameWeek " +
                "WHERE season_competition_id = " + seasonCompetitionId + " " +
                "ORDER BY gameweek_id;";

            return dbMan.ExecuteReader(query);
        }

        public int GetSeasonCompetitionId(int seasonId, int competitionId)
        {
            string query =
                "SELECT season_competition_id " +
                "FROM CompetitionInstance " +
                "WHERE season_id = " + seasonId +
                " AND competition_id = " + competitionId + ";";

            object result = dbMan.ExecuteScalar(query);

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }
        public int InsertMatch(int gameweekId,int seasonCompetitionId,int refereeId,string venue)
        {
            string query =
                "INSERT INTO Match (gameweek_id, season_competition_id, referee_id, Venue) " +
                "VALUES (" +
                gameweekId + ", " +
                seasonCompetitionId + ", " +
                refereeId + ", " +
                (string.IsNullOrEmpty(venue) ? "NULL" : "'" + venue + "'") +
                "); " +
                "SELECT SCOPE_IDENTITY();";

            object result = dbMan.ExecuteScalar(query);

            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }
        public int InsertMatchTeam(int matchId, int teamId, bool isHome)
        {
            string query =
                "INSERT INTO MatchTeams (match_id, team_id, is_home) VALUES (" +
                matchId + ", " +
                teamId + ", " +
                (isHome ? 1 : 0) +
                ");";

            return dbMan.ExecuteNonQuery(query);
        }





    }
}