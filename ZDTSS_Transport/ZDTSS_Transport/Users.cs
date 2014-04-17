using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class User
    {

        private int userId;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string userName;
        private string password;
        private int status;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// it updates here in the class and also in the database the new information!!!
        /// </summary>
        public void editProfile()
        {
            throw new System.NotImplementedException();
        }
    }
}
