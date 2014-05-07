﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZDTSS_Transport
{
    public class JobController
    {
        private Database database;
        
        private List<RegionsJob> regionsJobs;
        private List<Command> externCommands;

        private List<City> regions;


        public JobController(Database database)
        {
            this.database = database;
            regions = getRegions();
        }

        public Database Database
        {
            get { return database; }
            set { database = value; }
        }

        public List<RegionsJob> RegionsJobs
        {
            get { return regionsJobs; }
            set { regionsJobs = value; }
        }

        public List<Command> ExternCommands
        {
            get { return externCommands; }
            set { externCommands = value; }
        }

        public List<City> Regions
        {
            get { return regions; }
            set { regions = value; }
        }


        public void viewMorningJobs()
        {

            DataSet commandsDataSet = getYesterdaysCommands();
            List<Command> commands = getCommandsList(commandsDataSet);

            for (int i = 0; i < commands.Count; i++)
            {
                splitCommand(commands[i]); // updates the db and insert the splitted elements
                //MessageBox.Show(commands[i].ToString());
            }

            getCommandsSeparately();//getting the commands for each region;

            //1. step get the daily commands--use the date to select put everything into a list
            //2. separatization :  if intern command (inside of the the region) 1 day to collect them 2. day to deliver them
            //if not make 3 type of commands: 1:start to center-- 1. day, 2: center to ceter-- 2. day, 3: center to final 3.day
            //putting into a list each of them
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

                cmd.CommandId = (int)dr["commandId"];
                //cmd.VanId = (int) dr["vanId"]; --it is an empty field
                //cmd.DriverId = (int) dr["driverId"]; --empty field
                cmd.WareId = (int) dr["wareId"];
                cmd.StartCityId = (int)dr["startCityId"];
                cmd.DestCityId = (int)dr["destCityId"];
                cmd.StartTime = (DateTime)dr["startTime"];
                //cmd.FinishTime = (DateTime) dr["finishTime"];--empty
                cmd.CommandPrice = (int)dr["commandPrice"];
                cmd.UserId = (int)dr["customerId"];

                commands.Add(cmd);
            }
            return commands;
        }

        private DataSet getYesterdaysCommands()
        {
            //opening the connection with the database

            Database.SqlCon.Open();
            DataSet ds = new DataSet();
            //MessageBox.Show(DateTime.Today.AddDays(-1).ToString());

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM commands WHERE startTime>= '" + DateTime.Today.AddDays(-1) + "' AND startTime< '" + DateTime.Today + "'", Database.SqlCon);
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
            Database.SqlCon.Close();

            return ds;
        }

        private void splitCommand(Command command)
        {
            Database.SqlCon.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            string startRegion = "", destRegion = " ";
            int startRegionId = 0, destRegionId = 0;

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM cities", Database.SqlCon);
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
                        //MessageBox.Show(dr["region"].ToString());
                        destRegion = dr["region"].ToString();
                    }
                }
            }
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["cityName"].ToString() == startRegion)
                {
                    startRegionId = (int)dr["cityId"];
                }
                if (dr["cityName"].ToString() == destRegion)
                {
                    destRegionId = (int)dr["cityId"];
                }
            }
            SqlCommand cmd;
            if (startRegion == destRegion)
            {
                //split into 2
                //update database
                if ((command.StartCityId != startRegionId) &&(command.DestCityId!=startRegionId))
                {
                    //update the commands- start -> center
                    cmd = new SqlCommand("UPDATE commands SET destCityId=@regionId WHERE commandId=@cmdId",
                        Database.SqlCon);
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
                            "INSERT Into commands(wareId,startCityId,destCityId,startTime,commandPrice,customerID) VALUES (@wareId,@startCityId,@destCityId,@startTime,@commandPrice,@customerID)",
                            Database.SqlCon);
                    try
                    {
                        cmd.Parameters.Add("@wareId", SqlDbType.Int).Value = command.WareId;
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
                        Database.SqlCon);
                    {
                        cmd.Parameters.Add("@regionId", SqlDbType.Int).Value = startRegionId;
                        cmd.Parameters.Add("@cmdId", SqlDbType.Int).Value = command.CommandId;
                        cmd.ExecuteNonQuery();
                    }

                }
                //command -- center to center
                if ((command.StartCityId != startRegionId) && (command.DestCityId != destRegionId))
                {
                    cmd =
                        new SqlCommand(
                            "INSERT Into commands(wareId,startCityId,destCityId,startTime,commandPrice,customerID) VALUES (@wareId,@startCityId,@destCityId,@startTime,@commandPrice,@customerID)",
                            Database.SqlCon);
                    cmd.Parameters.Add("@wareId", SqlDbType.Int).Value = command.WareId;
                    cmd.Parameters.Add("@startCityId", SqlDbType.Int).Value = startRegionId;
                    cmd.Parameters.Add("@destCityId", SqlDbType.Int).Value = destRegionId;
                    cmd.Parameters.Add("@startTime", SqlDbType.DateTime).Value = command.StartTime.AddDays(1);
                    //cmd.Parameters.Add("@finishTime", SqlDbType.DateTime).Value = command.FinishTime;
                    cmd.Parameters.Add("@commandPrice", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = command.UserId;
                    cmd.ExecuteNonQuery();
                }
                
                
                if (destRegionId != command.DestCityId) // if the destination is not the regionCenter
                {
                    //creating new command  center -> destionation
                    cmd =
                        new SqlCommand(
                            "INSERT Into commands(wareId,startCityId,destCityId,startTime,commandPrice,customerID) VALUES (@wareId,@startCityId,@destCityId,@startTime,@commandPrice,@customerID)",
                            Database.SqlCon);
                    cmd.Parameters.Add("@wareId", SqlDbType.Int).Value = command.WareId;
                    cmd.Parameters.Add("@startCityId", SqlDbType.Int).Value = destRegionId;
                    cmd.Parameters.Add("@destCityId", SqlDbType.Int).Value = command.DestCityId;
                    cmd.Parameters.Add("@startTime", SqlDbType.DateTime).Value = command.StartTime.AddDays(2);
                    //cmd.Parameters.Add("@finishTime", SqlDbType.DateTime).Value = command.FinishTime;
                    cmd.Parameters.Add("@commandPrice", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = command.UserId;
                    cmd.ExecuteNonQuery();
                }
            }

            Database.SqlCon.Close();
        }

        private List<Van> getVansOrdered()
        {
            //getting the vans ordered by the loadCapacity*loadCapPallet

            Database.SqlCon.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            List<Van> vansList = new List<Van>();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vans ORDERED BY loadCapKg*loadCapPallet",
                Database.SqlCon);
            //getting the dataset from the adapter
            da.Fill(ds, "vans");
            dt = ds.Tables["vans"];
            //closing the connection

            foreach (DataRow dr in dt.Rows)
            {
                Van van = new Van();

                van.Consumption = (int)dr["consumption"];
                van.LoadCapKg = (int)dr["loadCapKg"];
                van.LoadCapPallet = (int)dr["loadCapPallet"];
                van.VanId = (int)dr["vanId"];
                van.VanName = (string)dr["vanName"];
                van.LoadCapKg = (int)dr["loadCapKg"];
                van.Speed = (int)dr["speed"];
                van.Status = (int)dr["status"];

                vansList.Add(van);

            }
            Database.SqlCon.Close();
            return vansList;
        }


        private List<City> getRegions()
        {

            database =new Database();
            database.connect();
            database.SqlCon.Open();
            

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            List<City> regions = new List<City>();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM cities WHERE cityName LIKE region",
                Database.SqlCon);
            //getting the dataset from the adapter
            da.Fill(ds, "cities");
            dt = ds.Tables["cities"];
            //closing the connection

            foreach (DataRow dr in dt.Rows)
            {
                City region = new City();

                region.CityId = (int)dr["cityId"];
                region.CityName = (string)dr["cityName"];
                region.Region = (string)dr["region"];
                //region.Status = (int) dr["hq"];

                regions.Add(region);
            }

            database.SqlCon.Close();
            return regions;

        }


        private void getCommandsSeparately()
        {
            //getting the interRegion commands

            //selecting from the cities the centers

            //database.SqlCon.Open();
            
            //getting yesterdays commands List
            List<Command> commands=getCommandsList(getYesterdaysCommands());

            externCommands=new List<Command>();

            foreach (Command command in commands)
            {
                //making three List-1 for interCollect, extern, interDivide

                //selecting the externs
                int extrVar=0;
                foreach (City region in regions)
                {
                    if (region.CityId == command.DestCityId)
                    {
                        extrVar++;
                    }
                    if (region.CityId == command.StartCityId)
                    {
                        extrVar++;
                    }
                }
                if (extrVar == 2)
                {
                    //extern command
                    externCommands.Add(command);
                    //commands.Remove(command);
                }
            }
            foreach (Command command in externCommands)
            {
                commands.Remove(command);
            }


            //previously the extern commands were deleted

            List<RegionsJob> jobForRegions=new List<RegionsJob>();

            foreach (City region in regions)
            {
                RegionsJob rj=new RegionsJob();
                //collect
                List<Command> collectCmd=new List<Command>();
                List<Ware> collectWares = new List<Ware>();

                List<Command> divideCmd = new List<Command>();
                List<Ware> divideWares=new List<Ware>();

                Ware wr=new Ware();

                foreach (Command command in commands)
                {
                    
                    if (region.CityId == command.DestCityId)
                    {
                        collectCmd.Add(command);
                        wr=getWare(command.WareId);
                        collectWares.Add(wr);
                        //commands.Remove(command);
                    }

                    if (region.CityId == command.StartCityId)
                    {
                        wr=getWare(command.WareId);
                        divideCmd.Add(command);
                        divideWares.Add(wr);
                        //commands.Remove(command);
                    }
                }

                //adding the list of commands for each region and also the list of wares

                rj.RegionName = region.CityName;
                rj.CollectCommandsList= collectCmd;
                rj.CollectWaresList = collectWares;

                rj.DivideCommandsList = divideCmd;
                rj.DivideWaresList = divideWares;

                jobForRegions.Add(rj);
            }
            //END of command separatization

            Database.SqlCon.Close();

            RegionsJobs = jobForRegions;
            //what remains is to show the list of commands
        }

        private Ware getWare(int wareId)
        {
            //getting the ware for the command
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            //there has to be just one
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM wares WHERE wareId= "+wareId,
                Database.SqlCon);
            //getting the dataset from the adapter
            da.Fill(ds, "wares");
            dt = ds.Tables["wares"];
            Ware ware = new Ware();

            foreach (DataRow dr in dt.Rows)
            {
                ware.WareId = (int)dr["wareId"];
                ware.Description = (string)dr["description"];
                ware.NrOfPallets = (int)dr["nrOfPallets"];
                ware.WeightPerPallet = (int)dr["weightPerPallet"];
            }

            return ware;
        }

        public DataTable convertToDatatable<T>(List<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

    }
}