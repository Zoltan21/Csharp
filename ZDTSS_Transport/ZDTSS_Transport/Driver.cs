using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class Driver
    {
        private int driverId;
        private string firstName;
        private string lastName;
        private int status;

        public int DriverId
        {
            get { return driverId; }
            set { driverId = value; }
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

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
