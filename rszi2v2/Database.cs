using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rszi2v2
{
    public class Database
    {
        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=rszi2v2");

        public void OpenConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Closed)
            {
                mySqlConnection.Open();

            }
        }
        public void ClosedConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                mySqlConnection.Close();

            }
        }

        public MySqlConnection getConnection()
        {
            return mySqlConnection;
        }
    }
}