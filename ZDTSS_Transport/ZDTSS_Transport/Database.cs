using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZDTSS_Transport
{
    public static class Database
    { //this is the default value, but it can be modified by the admin
        static string dbName = "ZDTSS_Transport";
//<<<<<<< HEAD
        static string serverName = @"NAGYZE-PC\SQLEXPRESS";
//=======
      // static string serverName = @"A-PC\SQLEXPRESS";
//>>>>>>> 559a318e28e3a2757ef835273d7d87a6315136fd
        public static SqlConnection sqlCon;

        //public SqlConnection SqlCon
        //{
        //    get { return sqlCon; }
        //}

        //public string DbName
        //{
        //    get { return dbName; }
        //    set { dbName = value; }
        //}

        //public string ServerName
        //{
        //    get { return serverName; }
        //    set { serverName = value; }
        //}

        public static void connect()
        {

            //connecting to the server
            try
            {
                sqlCon = new SqlConnection(@"Data Source=" + serverName + " ;Initial Catalog="+dbName+";Integrated Security=True");
                //sqlCon.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public static void disconnect()
        {
            if (sqlCon != null)
            {
                sqlCon.Close();
            }
        }


        //    //SqlConnection databaseCon = new SqlConnection(@"Data Source=NAGYZE-PC\SQLEXPRESS; Initial Catalog=Transport;Integrated Security=True");
    }
}
