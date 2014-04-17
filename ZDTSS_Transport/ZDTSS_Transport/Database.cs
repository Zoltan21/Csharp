using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class Database
    { //this is the default value, but it can be modified by the admin
        private string dbName = "ZDTSS_Transport";
        private string serverName;

        public string DbName
        {
            get { return dbName; }
            set { dbName = value; }
        }

        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }

        public void connect()
        {
            throw new System.NotImplementedException();
        }

        public void disconnect()
        {
            throw new System.NotImplementedException();
        }


        //    //SqlConnection databaseCon = new SqlConnection(@"Data Source=NAGYZE-PC\SQLEXPRESS; Initial Catalog=Transport;Integrated Security=True");
    }
}
