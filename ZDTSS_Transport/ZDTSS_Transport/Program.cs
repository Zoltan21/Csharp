using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ZDTSS_Transport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //this objects are always there doesen't matter if there is a client or an admin
            Database database = new Database();
            database.connect();
            User user=new User();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(database, user));
        }
    }
}
