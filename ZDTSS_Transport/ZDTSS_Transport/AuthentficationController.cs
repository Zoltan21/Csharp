using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class AuthentficationController
    {
        //use get and setter properties to access from the outside of the class!!!

        /// <summary>
        /// it don't need to instantieate here
        /// </summary>
        private User user;
        /// <summary>
        /// it don't need to instantieate here
        /// </summary>
        private Database database;

        public Database Database
        {
            get { return database; }
            set { database = value; }
        }

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        /// <summary>
        /// using the db,
        /// </summary>
        public int login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public void logout()
        {
            throw new System.NotImplementedException();
        }
    }
}
