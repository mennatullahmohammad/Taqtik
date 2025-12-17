using System;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Windows.Forms;
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

        public DataTable SelectAllTeams()
        {
            string query = "SELECT team_id, name FROM Team;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllPlayers(int teamid)
        {
            string query =
               " SELECT P.player_id, P.name FROM Player P" +
               " JOIN PlayerTeamSeason PTS ON P.player_id = PTS.player_id " +
               " JOIN TeamSeason TS ON PTS.team_season_id = TS.team_season_id " +
               " WHERE TS.team_id = " + teamid + ";";

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

        public DataTable YellowCard(int playerid)
        {
            string query = "SELECT COUNT(*) FROM Event E " +
                "JOIN EventType ET ON E.event_type_id = ET.event_type_id " +
                "WHERE E.player_id = " + playerid + " AND ET.name = 'Yellow Card'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable RedCard(int playerid)
        {
            string query = "SELECT COUNT(*) FROM Event E " +
                "JOIN EventType ET ON E.event_type_id = ET.event_type_id " +
                "WHERE E.player_id = " + playerid + " AND ET.name = 'Red Card'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Assists(int playerid)
        {
            string query = "SELECT COUNT(*) FROM Event E " +
                "JOIN EventType ET ON E.event_type_id = ET.event_type_id " +
                "WHERE E.player_id = " + playerid + " AND ET.name = 'Assist'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Shots(int playerid)
        {
            string query = "SELECT COUNT(*) FROM Event E " +
                "JOIN EventType ET ON E.event_type_id = ET.event_type_id " +
                "WHERE E.player_id = " + playerid + " AND ET.name = 'Shot'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Passes(int playerid)
        {
            string query = "SELECT COUNT(*) FROM Event E " +
                "JOIN EventType ET ON E.event_type_id = ET.event_type_id " +
                "WHERE E.player_id = " + playerid + " AND ET.name = 'Pass'";
            return dbMan.ExecuteReader(query);
        }
        public int SelectMatchesPlayed(int playerid)
        {
            string query = "SELECT COUNT(DISTINCT match_id) FROM Event " +
                           "WHERE player_id = " + playerid;

            return (int)dbMan.ExecuteScalar(query);
        }
        public int SelectMinutesPlayed(int playerid)
        {
            //if the sum turns out to be nothing, use 0 instead so the math doesn't crash.
            string query = @"
                SELECT 
                   (COUNT(DISTINCT E.match_id) * 90) - 
                   COALESCE(SUM(
                       CASE 
                           WHEN ET.name = 'Player In'  THEN E.time       
                           WHEN ET.name = 'Player Out' THEN 90 - E.time  
                           ELSE 0 
                       END
                   ), 0)
                FROM Event E
                JOIN EventType ET ON E.event_type_id = ET.event_type_id
                WHERE E.player_id = " + playerid;

            object result = dbMan.ExecuteScalar(query);
            return (result != null) ? Convert.ToInt32(result) : 0;
        
        }
    }
}