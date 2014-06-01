using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ZDTSS_Transport
{
    public class AuthentficationController
    {
        //use get and setter properties to access from the outside of the class!!!

        /// <summary>
        /// using the db,
        /// </summary>
        public User login(string userName, string password)
        {
            //cheking if the userName is in the Db, and filling the User object
            User user = new User();

            Database.sqlCon.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM users WHERE userName='"+userName+"' AND password='"+password+"'",Database.sqlCon);
            //the userNaem is unique
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    //getting user object
                    user.UserId = dataReader.GetInt32(0);
                    user.FirstName = dataReader.GetString(1);
                    user.LastName = dataReader.GetString(2);
                    user.PhoneNumber = dataReader.GetString(3);
                    user.UserName = dataReader.GetString(4);
                    user.Password = dataReader.GetString(5);
                    user.Status = dataReader.GetInt32(6);
                }
            }
            else
            {
                MessageBox.Show("ERROR: Wrong userName or Password");
                user = null;
            }
            Database.sqlCon.Close();

            return user;
        }

        public void register(string firstName, string lastName, string userName, string password, string passwordAgain,string phoneNumber)
        {
            //registering a new user-- put everything in the user class, and also the database
            if (CheckPasswd(password,passwordAgain))
            {
                if (!Empty(firstName, lastName, userName, password))
                {
                    if (SaveDataToDB(firstName, lastName, userName, password, phoneNumber))
                    {
                        MessageBox.Show("The new user was succesfully inserted into the Database!");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR! One of the arguments is empty or contains only whitespaces");
                }
            }
            else
            {
                MessageBox.Show("ERROR, password mismatch");
            }
        }
                
        private bool CheckPasswd(string password, string passwordCheck) //this method is used to check the correctness of the password
        {
            if (password == passwordCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Empty(string firstName, string lastName, string userName, string password)
        {
            if ((String.IsNullOrEmpty(firstName.Trim())) || (String.IsNullOrEmpty(lastName.Trim())) || (String.IsNullOrEmpty(userName.Trim())) || (String.IsNullOrEmpty(password.Trim())))
            {
                return true;
            }
            else
                return false;

        }

        private bool SaveDataToDB(string firstName, string lastName, string userName, string password, string phoneNumber)
        {
            SqlConnection databaseCon=Database.sqlCon;
            //databaseCon.Open();

            //SqlConnection databaseCon = new SqlConnection(@"Data Source=NAGYZE-PC\SQLEXPRESS; Initial Catalog=Transport;Integrated Security=True");
            SqlCommand dbCom = databaseCon.CreateCommand();

            databaseCon.Open();

            if (IsInDB(userName) == false)//check if the username is already in the database
            {
                dbCom.CommandText = "INSERT INTO users(firstName, lastName, userName, password, status, phoneNumber) VALUES (@firstname, @lastname, @username, @password, @status, @phoneNumber)";

                //using tranzaction, to roll-back if an error occurs
                SqlTransaction tx = databaseCon.BeginTransaction();
                try
                {
                    dbCom.Transaction = tx;
                    dbCom.Parameters.AddWithValue("@firstname", firstName);
                    dbCom.Parameters.AddWithValue("@lastname", lastName);
                    dbCom.Parameters.AddWithValue("@username", userName);
                    dbCom.Parameters.AddWithValue("@password", password);
                    dbCom.Parameters.AddWithValue("@status", 0);
                    dbCom.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    dbCom.ExecuteNonQuery();
                    dbCom.Parameters.Clear();
                    //if it cannot do the commit than there will be an exception
                    tx.Commit();
                    databaseCon.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    tx.Rollback();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("This username is already in the database ");
                return false;
            }
        }

        private bool IsInDB(string userName) //using the dataconnection
        {
            SqlConnection databaseCon = Database.sqlCon;
            bool result;

            SqlCommand databaseCom = databaseCon.CreateCommand();
            databaseCom.CommandText = "SELECT * FROM users WHERE username=" + "'" + userName + "'";
            SqlDataReader dataRead = databaseCom.ExecuteReader();

            result = dataRead.Read();//return true if the set is not empty or false
            dataRead.Close();

            return result;
        }

    }
}
