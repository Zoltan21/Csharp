﻿using System;
using System.Collections.Generic;
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
        /// manage==create, update , delete - Simon
        /// </summary>
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
                        AddCar(name,sp,w,v,c,st);
                        break;
                    }
                case "UpdateCar":
                    {
                        UpdateCar(id,name,sp,w,v,c,st);
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
        private void UpdateCar(int vanID ,string name, int speed, int weight, int volume, int consumption, int status)
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
            database.SqlCon.Close();
            database.SqlCon.Open();
            string sqltext = "DELETE FROM routes WHERE routeId=" + id;
            SqlCommand cmd = new SqlCommand(sqltext, database.SqlCon);
            //cmd.CommandText = "DELETE FROM routes WHERE routeId=" + id;

            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            database.SqlCon.Close();
        }
        public void deleteCommand(int id)
        {
            database.SqlCon.Close();
            database.SqlCon.Open();
            string sqltext = "DELETE FROM commands WHERE commandId=" + id;
            SqlCommand cmd = new SqlCommand(sqltext, database.SqlCon);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            database.SqlCon.Close();
        }
        public void deletePrice(int id)
        {
            database.SqlCon.Close();
            database.SqlCon.Open();
            string sqltext = "DELETE FROM prices WHERE p_Id=" + id;
            SqlCommand cmd = new SqlCommand(sqltext, database.SqlCon);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            database.SqlCon.Close();
        }
        public DataTable viewCommands()
        {
            database.SqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM commands", database.SqlCon);
            sda.Fill(dt);
            return dt;
            database.SqlCon.Close();
        }
        public DataTable viewPrices()
        {
            database.SqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM prices", database.SqlCon);
            sda.Fill(dt);
            return dt;
            database.SqlCon.Close();
        }
        public DataTable viewRoutes()
        {
            database.SqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM routes", database.SqlCon);
            sda.Fill(dt);
            return dt;
            database.SqlCon.Close();
        }
        public void viewMorningJobs()
        {

            DataSet commandsDataSet = getYesterdaysCommands();
            List<Command> commands = getCommandsList(commandsDataSet);

            for (int i = 0; i < commands.Count; i++)
            {
                splitCommand(commands[i]); // updates the db and insert the splitted elements
                MessageBox.Show(commands[i].ToString());
            }


            //selecting the cities to check if they are in the same region or not

            DataTable dt = new DataTable();

            dt = commandsDataSet.Tables["commands"];


            //1. step get the daily commands--use the date to select put everything into a list

            //2. separatization :  if intern command (inside of the the region) 1 day to collect them 2. day to deliver them
            //if not make 3 type of commands: 1:start to center-- 1. day, 2: center to ceter-- 2. day, 3: center to final 3.day
            //putting into a list each of them

            //3. 

            //throw new System.NotImplementedException();
        }

        private List<Command> getCommandsList(DataSet commandsDataSet)
        {
            //pasing from dataSet to a list of commands
            List<Command> commands = new List<Command>();
            DataTable dt = new DataTable();
            dt = commandsDataSet.Tables["commands"];

            foreach (DataRow dr in dt.Rows)
            {
                Command cmd = new Command();

                cmd.CommandId = (int) dr["commandId"];
                //cmd.VanId = (int) dr["vanId"]; --it is an empty field
                //cmd.DriverId = (int) dr["driverId"]; --empty field
                //cmd.WareId = (int) dr["wareId"];--empty field
                cmd.StartCityId = (int) dr["startCityId"];
                cmd.DestCityId = (int) dr["destCityId"];
                cmd.StartTime = (DateTime) dr["startTime"];
                //cmd.FinishTime = (DateTime) dr["finishTime"];--empty
                cmd.CommandPrice = (int) dr["commandPrice"];
                cmd.UserId = (int) dr["customerId"];

                commands.Add(cmd);
            }
            return commands;
        }

        private DataSet getYesterdaysCommands()
        {
            //opening the connection with the database
            
            database.SqlCon.Open();
            DataSet ds = new DataSet();
            MessageBox.Show(DateTime.Today.AddDays(-1).ToString());
           
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM commands WHERE startTime>= '"+DateTime.Today.AddDays(-1) +"' AND startTime< '"+DateTime.Today+"'", database.SqlCon);
            //getting the dataset from the adapter
            try
            {
                da.Fill(ds, "commands");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            //closing the connection
            database.SqlCon.Close();

            return ds;
        }

        private void splitCommand(Command command)
        {
            database.SqlCon.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            string startRegion = "", destRegion = " ";
            int startRegionId = 0, destRegionId = 0;

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM cities", database.SqlCon);
            //getting the dataset from the adapter
            da.Fill(ds, "cities");
            dt = ds.Tables["cities"];
            //closing the connection

            foreach (DataRow dr in dt.Rows)
            {
                if (int.Parse(dr["cityId"].ToString()) == command.StartCityId)
                {
                    startRegion = dr["region"].ToString();
                }
                else
                {
                    if (int.Parse(dr["cityId"].ToString()) == command.DestCityId)
                    {
                        MessageBox.Show(dr["region"].ToString());
                        destRegion = dr["region"].ToString();
                    }
                }
            }
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["cityName"].ToString() == startRegion)
                {
                    startRegionId = (int) dr["cityId"];
                }
                else
                {
                    if (dr["cityName"].ToString() == destRegion)
                    {
                        destRegionId = (int) dr["cityId"];
                    }
                }
            }
            SqlCommand cmd;
            if (startRegion == destRegion)
            {
                //split into 2
                //update database
                if (command.StartCityId != startRegionId)
                {
                    //update the commands- start -> center
                    cmd = new SqlCommand("UPDATE commands SET destCityId=@regionId WHERE commandId=@cmdId",
                        database.SqlCon);
                    try
                    {
                        cmd.Parameters.Add("@regionId", SqlDbType.Int).Value = startRegionId;
                        cmd.Parameters.Add("@cmdId", SqlDbType.Int).Value = command.CommandId;
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    //creating new command  center -> destionation
                    cmd =
                        new SqlCommand(
                            //"INSERT Into commands(wareId,startCityId,destCityId,startTime,finishTime,commandPrice,customerID) VALUES (@wareId,@startCityId,@destCityId,@startTime,@finishTime,@commandPrice,@customerID)",
                            "INSERT Into commands(startCityId,destCityId,startTime,commandPrice,customerID) VALUES (@startCityId,@destCityId,@startTime,@commandPrice,@customerID)",
                            database.SqlCon);
                    try
                    {
                        //cmd.Parameters.Add("@wareId", SqlDbType.Int).Value = command.WareId;
                        cmd.Parameters.Add("@startCityId", SqlDbType.Int).Value = startRegionId;
                        cmd.Parameters.Add("@destCityId", SqlDbType.Int).Value = command.DestCityId;
                        cmd.Parameters.Add("@startTime", SqlDbType.DateTime).Value = command.StartTime.AddDays(1);
                        //cmd.Parameters.Add("@finishTime", SqlDbType.DateTime).Value = command.FinishTime;
                        cmd.Parameters.Add("@commandPrice", SqlDbType.Int).Value = 0;
                        cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = command.UserId;
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }

                }
            }
            else
            {
                //split into 3 
                if (command.StartCityId != startRegionId)
                {
                    //update the commands- start -> center
                    cmd = new SqlCommand("UPDATE commands SET destCityId=@regionId WHERE commandId=@cmdId",
                        database.SqlCon);
                    {
                        cmd.Parameters.Add("@regionId", SqlDbType.Int).Value = startRegionId;
                        cmd.Parameters.Add("@cmdId", SqlDbType.Int).Value = command.CommandId;
                        cmd.ExecuteNonQuery();
                    }
                }
                //new command center to center
                cmd =
                    new SqlCommand(
                        "INSERT Into commands(startCityId,destCityId,startTime,commandPrice,customerID) VALUES (@startCityId,@destCityId,@startTime,@commandPrice,@customerID)",
                        database.SqlCon);
                //cmd.Parameters.Add("@wareId", SqlDbType.Int).Value = command.WareId;
                cmd.Parameters.Add("@startCityId", SqlDbType.Int).Value = startRegionId;
                cmd.Parameters.Add("@destCityId", SqlDbType.Int).Value = destRegionId;
                cmd.Parameters.Add("@startTime", SqlDbType.DateTime).Value = command.StartTime.AddDays(1);
                //cmd.Parameters.Add("@finishTime", SqlDbType.DateTime).Value = command.FinishTime;
                cmd.Parameters.Add("@commandPrice", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = command.UserId;
                cmd.ExecuteNonQuery();
                if (destRegionId != command.DestCityId) // if the destination is not the regionCenter
                {
                    //creating new command  center -> destionation
                    cmd =
                        new SqlCommand(
                            "INSERT Into commands(startCityId,destCityId,startTime,commandPrice,customerID) VALUES (@startCityId,@destCityId,@startTime,@commandPrice,@customerID)",
                            database.SqlCon);
                    //cmd.Parameters.Add("@wareId", SqlDbType.Int).Value = command.WareId;
                    cmd.Parameters.Add("@startCityId", SqlDbType.Int).Value = destRegionId;
                    cmd.Parameters.Add("@destCityId", SqlDbType.Int).Value = command.DestCityId;
                    cmd.Parameters.Add("@startTime", SqlDbType.DateTime).Value = command.StartTime.AddDays(2);
                    //cmd.Parameters.Add("@finishTime", SqlDbType.DateTime).Value = command.FinishTime;
                    cmd.Parameters.Add("@commandPrice", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = command.UserId;
                    cmd.ExecuteNonQuery();
                }
            }

            database.SqlCon.Close();
        }

    }
}
