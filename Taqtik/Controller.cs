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
        public bool CompetitionInstanceExists(int seasonId, int competitionId)
        {
            string q =
                "SELECT COUNT(*) FROM CompetitionInstance " +
                "WHERE season_id = " + seasonId +
                " AND competition_id = " + competitionId + ";";

            return Convert.ToInt32(dbMan.ExecuteScalar(q)) > 0;
        }
        public int InsertTeamSeason(int teamId, int seasonCompetitionId)
        {
            string q =
                "INSERT INTO TeamSeason (team_id, season_competition_id) VALUES (" +
                teamId + ", " + seasonCompetitionId + ");";

            return dbMan.ExecuteNonQuery(q);
        }
        public bool SeasonExists(int year)
        {
            string q = "SELECT COUNT(*) FROM Season WHERE year = " + year + ";";
            return Convert.ToInt32(dbMan.ExecuteScalar(q)) > 0;
        }

        public int InsertSeason(int year)
        {
            string q = "INSERT INTO Season (year) VALUES (" + year + ");";
            return dbMan.ExecuteNonQuery(q);
        }

        public int InsertPlayer(string name, int? age, string position)
        {
            if (string.IsNullOrWhiteSpace(name))
                return 0;

            string safeName = name.Replace("'", "''");
            string posSql = string.IsNullOrWhiteSpace(position) ? "NULL" : "'" + position.Replace("'", "''") + "'";
            string ageSql = age.HasValue ? age.Value.ToString() : "NULL";

            string q =
                "INSERT INTO Player (name, age, position) VALUES (" +
                "'" + safeName + "', " + ageSql + ", " + posSql + ");";

            return dbMan.ExecuteNonQuery(q);
        }
        public int InsertTeam(string name, string country, int? yearFounded)
        {
            if (string.IsNullOrWhiteSpace(name))
                return 0;

            string safeName = name.Replace("'", "''");
            string countrySql = string.IsNullOrWhiteSpace(country) ? "NULL" : "'" + country.Replace("'", "''") + "'";
            string yearSql = yearFounded.HasValue ? yearFounded.Value.ToString() : "NULL";

            string q =
                "INSERT INTO Team (name, country, year_founded) VALUES (" +
                "'" + safeName + "', " + countrySql + ", " + yearSql + ");";

            return dbMan.ExecuteNonQuery(q);
        }
        public DataTable SelectAllEventTypes()
        {
            string q = "SELECT event_type_id, name FROM EventType ORDER BY name;";
            return dbMan.ExecuteReader(q);
        }
        public DataTable SelectAllMatches()
        {
            string q = "SELECT match_id FROM Match ORDER BY match_id DESC;";
            return dbMan.ExecuteReader(q);
        }
        public DataTable SelectMatchesForCombo()
        {
            string q =
                "SELECT m.match_id, " +
                "       'GW' + CAST(m.gameweek_id AS VARCHAR(10)) + ' | ' + " +
                "       ISNULL(ht.name,'?') + ' vs ' + ISNULL(at.name,'?') AS display_text " +
                "FROM [Match] m " +
                "LEFT JOIN MatchTeams mth ON mth.match_id = m.match_id AND mth.is_home = 1 " +
                "LEFT JOIN Team ht ON ht.team_id = mth.team_id " +
                "LEFT JOIN MatchTeams mta ON mta.match_id = m.match_id AND mta.is_home = 0 " +
                "LEFT JOIN Team at ON at.team_id = mta.team_id " +
                "ORDER BY m.match_id DESC;";

            return dbMan.ExecuteReader(q);
        }

        public int InsertEvent(int matchId, int eventTypeId, int playerId, int minute, int second, int enteredBy)
        {
            string q =
                "INSERT INTO Event (match_id, event_type_id, player_id, minute, second, entered_by) VALUES (" +
                matchId + ", " + eventTypeId + ", " + playerId + ", " + minute + ", " + second + ", " + enteredBy + ");";

            return dbMan.ExecuteNonQuery(q);
        }



        public bool TeamSeasonExists(int teamId, int seasonCompetitionId)
        {
            string q =
                "SELECT COUNT(*) FROM TeamSeason " +
                "WHERE team_id = " + teamId +
                " AND season_competition_id = " + seasonCompetitionId + ";";

            return Convert.ToInt32(dbMan.ExecuteScalar(q)) > 0;
        }

        public int InsertCompetitionInstance(int seasonId, int competitionId, int? promotion, int relegation, int numberOfTeams)
        {
            string promoSql = promotion.HasValue ? promotion.Value.ToString() : "NULL";

            string q =
                "INSERT INTO CompetitionInstance (season_id, competition_id, promotion_spots, relegation_spots, number_of_teams) " +
                "VALUES (" + seasonId + ", " + competitionId + ", " + promoSql + ", " + relegation + ", " + numberOfTeams + ");";

            return dbMan.ExecuteNonQuery(q);
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
        public int InsertReferee(string name, int? age, string country)
        {
            // name is required
            if (string.IsNullOrWhiteSpace(name)) return 0;

            string ageSql = (age.HasValue ? age.Value.ToString() : "NULL");
            string countrySql = (string.IsNullOrWhiteSpace(country) ? "NULL" : "'" + country.Replace("'", "''") + "'");

            string query =
                "INSERT INTO Referee (name, age, country) VALUES (" +
                "'" + name.Replace("'", "''") + "', " +
                ageSql + ", " +
                countrySql +
                ");";

            return dbMan.ExecuteNonQuery(query); // returns affected rows
        }

        public int InsertCompetition(string name, string country)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(country))
                return 0;

            string safeName = name.Replace("'", "''");
            string safeCountry = country.Replace("'", "''");

            string query =
                "INSERT INTO Competition (name, country) VALUES (" +
                "'" + safeName + "', '" + safeCountry + "');";

            return dbMan.ExecuteNonQuery(query);
        }


        public int GetUserIdByUsername(string username)
        {
            string safe = username.Replace("'", "''");
            string q = "SELECT user_id FROM Users WHERE name = '" + safe + "';";
            object r = dbMan.ExecuteScalar(q);
            if (r == null || r == DBNull.Value) return -1;
            return Convert.ToInt32(r);
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