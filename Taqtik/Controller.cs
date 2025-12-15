using System;
using System.Data;
using System.Globalization;
using Taqtik;

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
            string query = "SELECT COUNT(*) FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "';";

            return (int)dbMan.ExecuteScalar(query);
        }



    }
}