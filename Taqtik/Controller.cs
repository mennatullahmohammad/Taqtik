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
                string queryUser = "INSERT INTO Users (name, password_hash, role, is_subscribed) " +
                           "VALUES ('" + name + "','" + password + "','" + role + "', 0); " +
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
        public DataTable SelectTeamByUsername(string username)
        {
            string query = "SELECT T.team_id, T.name, T.country, T.year_founded " +
                           "FROM Team T " +
                           "JOIN UserTeamAccess A ON T.team_id = A.team_id " +
                           "JOIN Users U ON U.user_id = A.user_id " +
                           "WHERE U.name = '" + username + "';";

            return dbMan.ExecuteReader(query);
        }


    }
}