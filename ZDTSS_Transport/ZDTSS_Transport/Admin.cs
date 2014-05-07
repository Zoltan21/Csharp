using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ZDTSS_Transport
{
    public class AdminController
    {
        private Database database;

        public AdminController(Database database)
        {
            this.database = database;
        }

        public Database Database
        {
            get { return database; }
            set { database = value; }
        }

        /// <summary>
        /// delete, add, modify commands
        /// </summary>
        public void manageCommand()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// showing a report about the current state of the processes, where are the cars
        /// </summary>
        public void viewReport()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// viewStatus all the commands and also possibility to special selection for each client
        /// </summary>
        public void viewAllCommands()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// manage==create, modify, delete
        /// </summary>
        public void manageRoutes()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// manage==create, modify, delete
        /// </summary>
        public void managePrices()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// add Client to admin, change info about client, delete client
        /// </summary>
        public void manageClients()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// each morning calculates the optimal solution from the point of viewStatus of capacity and "travellin salesman" for the day
        /// </summary>
        public void deleteRoute(int id)
        {
            Database.SqlCon.Close();
            Database.SqlCon.Open();
            string sqltext = "DELETE FROM routes WHERE routeId=" + id;
            SqlCommand cmd = new SqlCommand(sqltext, Database.SqlCon);
            //cmd.CommandText = "DELETE FROM routes WHERE routeId=" + id;

            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            Database.SqlCon.Close();
        }
        public void deleteCommand(int id)
        {
            Database.SqlCon.Close();
            Database.SqlCon.Open();
            string sqltext = "DELETE FROM commands WHERE commandId=" + id;
            SqlCommand cmd = new SqlCommand(sqltext, Database.SqlCon);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            Database.SqlCon.Close();
        }
        public void deletePrice(int id)
        {
            Database.SqlCon.Close();
            Database.SqlCon.Open();
            string sqltext = "DELETE FROM prices WHERE p_Id=" + id;
            SqlCommand cmd = new SqlCommand(sqltext, Database.SqlCon);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            Database.SqlCon.Close();
        }
        public DataTable viewCommands()
        {
            Database.SqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM commands", Database.SqlCon);
            sda.Fill(dt);
            Database.SqlCon.Close();
            return dt;
            
        }
        public DataTable viewPrices()
        {
            Database.SqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM prices", Database.SqlCon);
            sda.Fill(dt);
            Database.SqlCon.Close();
            return dt;
            
        }
        public DataTable viewRoutes()
        {
            Database.SqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM routes", Database.SqlCon);
            sda.Fill(dt);
            Database.SqlCon.Close();
            return dt;
            
        }





        //Simon's   part

        public void manageCars(string option, string vanID, string name, string speed, string weight, string volume, string consumption, string status)
        {
            int id = Convert.ToInt32(vanID);
            int sp = Convert.ToInt32(speed);
            int w = Convert.ToInt32(weight);
            int v = Convert.ToInt32(volume);
            int c = Convert.ToInt32(consumption);
            int st = Convert.ToInt32(status);
            switch (option)
            {
                case "AddCar":
                    {
                        AddCar(name, sp, w, v, c, st);
                        break;
                    }
                case "UpdateCar":
                    {
                        UpdateCar(id, name, sp, w, v, c, st);
                        break;
                    }
                case "DeleteCar":
                    {
                        DeleteCar(id);
                        break;
                    }
                default:
                    break;
            }
        }
        //inserting cars into DB - Simon
        private void AddCar(string name, int speed, int weight, int volume, int consumption, int status)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=DAROACH-PC\SQLEXPRESS;Initial Catalog= ZDTSS_Transport; Integrated Security=True ";
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("INSERT Into vans(vanName, speed, loadCapKg, loadCapPallet, consumption, vanStatus) VALUES (@n, @speed, @kg, @p, @c, @status)", sqlCon);
            cmd.Parameters.Add("@n", SqlDbType.Text).Value = name;
            cmd.Parameters.Add("@speed", SqlDbType.Int).Value = speed;
            cmd.Parameters.Add("@kg", SqlDbType.Int).Value = weight;
            cmd.Parameters.Add("@p", SqlDbType.Int).Value = volume;
            cmd.Parameters.Add("@c", SqlDbType.Int).Value = consumption;
            cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;
            try
            {
                cmd.ExecuteNonQuery();
                const string message = "New Car successfully added !";
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                string message = ex.Message.ToString();
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            sqlCon.Close();

        }
        // Update function for cars - Simon
        private void UpdateCar(int vanID, string name, int speed, int weight, int volume, int consumption, int status)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=DAROACH-PC\SQLEXPRESS;Initial Catalog= ZDTSS_Transport; Integrated Security=True ";
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("UPDATE vans SET vanName=@n, speed=@sp, loadCapKg=@w, loadCapPallet=@v, consumption=@c, vanStatus=@st WHERE vanId LIKE @id", sqlCon);
            cmd.Parameters.Add("@n", SqlDbType.Text).Value = name;
            cmd.Parameters.Add("@sp", SqlDbType.Int).Value = speed;
            cmd.Parameters.Add("@w", SqlDbType.Int).Value = weight;
            cmd.Parameters.Add("@v", SqlDbType.Int).Value = volume;
            cmd.Parameters.Add("@c", SqlDbType.Int).Value = consumption;
            cmd.Parameters.Add("@st", SqlDbType.Int).Value = status;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = vanID;
            try
            {
                cmd.ExecuteNonQuery();
                string msg = "Car sucessfully updated!";
                string cap = "Form Closing";
                var res = MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                string message = ex.Message.ToString();
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlCon.Close();
        }
        // not complete, error in the syntax - Simon
        private void DeleteCar(int carID)
        {

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=DAROACH-PC\SQLEXPRESS;Initial Catalog= ZDTSS_Transport; Integrated Security=True ";
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM vans WHERE vanId LIKE @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = carID;
            cmd.Connection = sqlCon;
            try
            {
                cmd.ExecuteNonQuery();
                string msg = "Car sucessfully deleted!";
                string cap = "Form Closing";
                var res = MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                string message = ex.Message.ToString();
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlCon.Close();
        }

        public void manageClients(string option, string userID, string userFirstName, string userLastName, string phonenumber, string username, string password, string userStatus)
        {
            int id = Convert.ToInt32(userID);
            int status = Convert.ToInt32(userStatus);
            switch (option)
            {
                case "AddClient":
                    AddClient(userFirstName, userFirstName, phonenumber, username, password, status);
                    break;
                case "UpdateClient":
                    UpdateClient(id, userFirstName, userLastName, phonenumber, username, password, status);
                    break;
                case "DeleteClient":
                    DeleteClient(id);
                    break;
                default:
                    break;
            }
        }

        private void AddClient(string fName, string lName, string phone, string uName, string pass, int status)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=DAROACH-PC\SQLEXPRESS;Initial Catalog= ZDTSS_Transport; Integrated Security=True ";
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("INSERT Into users(firstName, lastName, phoneNumber, userName, password, status) VALUES (@fn, @ln, @ph, @un, @pass, @st)", sqlCon);
            cmd.Parameters.Add("@fn", SqlDbType.NChar).Value = fName;
            cmd.Parameters.Add("@ln", SqlDbType.NChar).Value = lName;
            cmd.Parameters.Add("@ph", SqlDbType.NChar).Value = phone;
            cmd.Parameters.Add("@un", SqlDbType.NChar).Value = uName;
            cmd.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            cmd.Parameters.Add("@st", SqlDbType.Int).Value = status;
            try
            {
                cmd.ExecuteNonQuery();
                const string message = "New client successfully added !";
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                string message = ex.Message.ToString();
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            sqlCon.Close();
        }

        private void UpdateClient(int userID, string fName, string lName, string phone, string uName, string pass, int status)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=DAROACH-PC\SQLEXPRESS;Initial Catalog= ZDTSS_Transport; Integrated Security=True ";
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("UPDATE users SET firstName=@fn, lastName=@ln, phoneNumber=@ph, userName=@un, password=@pass, status=@st WHERE userId LIKE @id", sqlCon);
            cmd.Parameters.Add("@fn", SqlDbType.NChar).Value = fName;
            cmd.Parameters.Add("@ln", SqlDbType.NChar).Value = lName;
            cmd.Parameters.Add("@ph", SqlDbType.NChar).Value = phone;
            cmd.Parameters.Add("@un", SqlDbType.NChar).Value = uName;
            cmd.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            cmd.Parameters.Add("@st", SqlDbType.NChar).Value = status;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userID;
            try
            {
                cmd.ExecuteNonQuery();
                string msg = "Client sucessfully updated!";
                string cap = "Form Closing";
                var res = MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                string message = ex.Message.ToString();
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlCon.Close();

        }

        private void DeleteClient(int clientID)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=DAROACH-PC\SQLEXPRESS;Initial Catalog= ZDTSS_Transport; Integrated Security=True ";
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE userId LIKE @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = clientID;
            cmd.Connection = sqlCon;
            try
            {
                cmd.ExecuteNonQuery();
                string msg = "Client sucessfully deleted!";
                string cap = "Form Closing";
                var res = MessageBox.Show(msg, cap, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                string message = ex.Message.ToString();
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlCon.Close();
        }
    }
}
