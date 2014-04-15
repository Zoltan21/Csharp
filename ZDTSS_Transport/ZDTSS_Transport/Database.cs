using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class Database
    {
        private string datasource=@"NAGYZE-PC\SQLEXPRESS"; //this is the default value, but it can be modified by the admin
        private string dbname = "ZDTSS_Transport";

        public string Datasource
        {
            get { return datasource; }
            set { datasource = value; }
        }

        public string Dbname
        {
            get { return dbname; }
            set { dbname = value; }
        }

        public bool connectingToDb()
        {
            throw new System.NotImplementedException();
        }

        public bool changeDbSettings()
        {
            throw new System.NotImplementedException();
        }

        public bool disconnect()
        {
            throw new System.NotImplementedException();
        }


        //    //SqlConnection databaseCon = new SqlConnection(@"Data Source=NAGYZE-PC\SQLEXPRESS; Initial Catalog=Transport;Integrated Security=True");
    }
}
