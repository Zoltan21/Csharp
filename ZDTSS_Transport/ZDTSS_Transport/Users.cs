using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

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
        ///it updates here in the class and also in the database the new information!!!
        /// </summary>
        public void editProfile()
        {
            throw new System.NotImplementedException();
        }

        public void createUser(string firstName, string lastName, string password, string passwordAgain, string phoneNr, string status, string userName)
        {
            //creating a new user- checking password correctness
            if (isNotEmpty(firstName, lastName, password, userName))
            {
                if (checkPassword(password,passwordAgain))
                {
                    this.firstName=firstName;
                    this.lastName=lastName;
                    this.phoneNumber=phoneNr;
                    this.userName=userName;
                    this.password=password;
                    this.status=0;
                }
            }
        }

        private bool checkPassword(string password, string passwordAgain) //this method is used to check the correctness of the password
        {
            if (password == passwordAgain)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isNotEmpty(string firstName, string lastName, string password, string userName)
        {
            if ((String.IsNullOrEmpty(firstName.Trim())) || (String.IsNullOrEmpty(lastName.Trim())) ||
                (String.IsNullOrEmpty(password.Trim())) || (String.IsNullOrEmpty(userName.Trim())))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addUserToDb()
        {
            //adding a new user to the database
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void updateUserInDb(User user, int userId)
        {// updating a user
            Database.sqlCon.Open();
            SqlCommand cmd = new SqlCommand("UPDATE users SET firstName=@firstName, lastName=@lastName, phoneNumber=@phoneNumber ,userName=@userName, password=@password WHERE userId=@userId", Database.sqlCon);
            try
            {
                cmd.Parameters.Add("@firstName", SqlDbType.NChar).Value = user.FirstName;
                cmd.Parameters.Add("@lastName", SqlDbType.NChar).Value = user.LastName;
                cmd.Parameters.Add("@phoneNumber", SqlDbType.NChar).Value = user.PhoneNumber;
                cmd.Parameters.Add("@userName", SqlDbType.NChar).Value = user.UserName;
                cmd.Parameters.Add("@password", SqlDbType.NChar).Value = user.Password;
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Database.sqlCon.Close();
        }
    }
}
