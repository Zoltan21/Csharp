using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class User
    {

        private int _userId;
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _userName;
        private string _password;
        private int _status;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public bool login()
        {
            throw new System.NotImplementedException();
        }

        public bool register()
        {
            throw new System.NotImplementedException();
        }
    }
}
