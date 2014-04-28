using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZDTSS_Transport
{
    public class Database
    { //this is the default value, but it can be modified by the admin
        private string dbName = "ZDTSS_Transport";
        private string serverName="NagyZe-PC";
        private SqlConnection sqlCon;

        public SqlConnection SqlCon
        {
            get { return sqlCon; }
        }

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

            //connecting to the server
            try
            {
                sqlCon = new SqlConnection(@"Data Source=" + serverName + @"\SQLEXPRESS ;Initial Catalog="+dbName+";Integrated Security=True");
                sqlCon.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void disconnect()
        {
            if (sqlCon != null)
            {
                sqlCon.Close();
            }
        }


        //    //SqlConnection databaseCon = new SqlConnection(@"Data Source=NAGYZE-PC\SQLEXPRESS; Initial Catalog=Transport;Integrated Security=True");
    }
}
