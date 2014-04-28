using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZDTSS_Transport
{
    public partial class Register : Form
    {

        User user;

        public Register(User user)
        {
            this.user = user;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (CheckPasswd())
            {
                if (!Empty())
                {
                    if (SaveDataToDB())
                    {
                        this.Owner.Show();
                        this.Close();
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


        private bool CheckPasswd() //this method is used to check the correctness of the password
        {
            String passwd = txtPassword.Text;
            String passwdCheck = txtPasswordAgain.Text;
            if (passwd == passwdCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Empty()
        {
            if ((String.IsNullOrEmpty(txtUserId.Text.Trim())) || (String.IsNullOrEmpty(txtFirstName.Text.Trim())) || (String.IsNullOrEmpty(txtLastName.Text.Trim())) || (String.IsNullOrEmpty(txtPassword.Text.Trim())))
            {
                return true;
            }
            else
                return false;
            
        }

        private bool SaveDataToDB()
        {
            SqlConnection databaseCon = new SqlConnection(@"Data Source=NAGYZE-PC\SQLEXPRESS; Initial Catalog=Transport;Integrated Security=True");
            SqlCommand dbCom = databaseCon.CreateCommand();
            
            databaseCon.Open();

            if (IsInDB(databaseCon)==false)//check if the username is already in the database
            {
                dbCom.CommandText = "INSERT INTO users(firstname, lastname, username, password) VALUES (@firstname, @lastname, @username, @password)";

                //using tranzaction, to roll-back if an error occurs
                SqlTransaction tx = databaseCon.BeginTransaction();
                try
                {
                    dbCom.Transaction = tx;
                    dbCom.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                    dbCom.Parameters.AddWithValue("@lastname", txtLastName.Text);
                    dbCom.Parameters.AddWithValue("@username", txtUserId.Text);
                    dbCom.Parameters.AddWithValue("@password", txtPassword.Text);
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

        private bool IsInDB(SqlConnection databaseCon) //using the dataconnection
        {
            bool result; 
            String username = txtUserId.Text;

            SqlCommand databaseCom = databaseCon.CreateCommand();
            databaseCom.CommandText = "SELECT * FROM users WHERE username="+"'"+username+"'";
            SqlDataReader dataRead = databaseCom.ExecuteReader();

            result=dataRead.Read();//return true if the set is not empty or false
            dataRead.Close();

            return result;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

    }
}
