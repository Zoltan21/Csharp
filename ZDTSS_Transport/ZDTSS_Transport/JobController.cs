using System;
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
        
        private List<RegionsJob> regionsJobs;
        private List<Command> externCommands;

        private List<City> regions;


        public JobController()
        {
            regions = getRegions();
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

        public void commandsSplitting()
        {     
            DataSet commandsDataSet = getUnselectedCommands();
            List<Command> commands = getCommandsList(commandsDataSet);

            for (int i = 0; i < commands.Count; i++)
            {
                splitCommand(commands[i]); // updates the db and insert the splitted elements
                //MessageBox.Show(commands[i].ToString());
            }
            getCommandsSeparately();//getting the commands for each region
        }

        public void viewMorningJobs()
        {
            //list of all the jobs inside each region
            foreach(RegionsJob rj in regionsJobs)
            {
                //sorting commands
                rj.CollectCommandsList=sortingCommandByWare(rj.CollectCommandsList);
                rj.DivideCommandsList=sortingCommandByWare(rj.DivideCommandsList);
                //putting wares into the Vans
                rj.CollectCommandsList = addingWaresToVan(rj.CollectCommandsList, rj.RegionId);
                rj.DivideCommandsList = addingWaresToVan(rj.DivideCommandsList, rj.RegionId);
            }
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
                cmd.CommandPrice = (int)dr["commandPrice"];
                cmd.UserId = (int)dr["customerId"];
                cmd.CommandStatus=(int)dr["commandStatus"];

                commands.Add(cmd);
            }
            return commands;
        }

        private DataSet getUnselectedCommands()
        {
            //opening the connection with the database
            Database.sqlCon.Open();
            DataSet ds = new DataSet();
            //MessageBox.Show(DateTime.Today.AddDays(-1).ToString());

            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM commands WHERE startTime>= '" + DateTime.Today.AddDays(-1) + "' AND startTime< '" + DateTime.Today + "'", Database.sqlCon);
            //selecting commands with date less than today
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM commands WHERE commandStatus=0 AND startTime<='" + DateTime.Today + "'", Database.sqlCon);
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
            Database.sqlCon.Close();
            return ds;
        }

        private void insertCommandIntoDb(Command command,int fromCityId,int toCityId, int days)
        {
            SqlCommand cmd =
                        new SqlCommand(
                //"INSERT Into commands(wareId,startCityId,destCityId,startTime,finishTime,commandPrice,customerID) VALUES (@wareId,@startCityId,@destCityId,@startTime,@finishTime,@commandPrice,@customerID)",
                            "INSERT Into commands(wareId,startCityId,destCityId,startTime,commandPrice,customerID,commandStatus) VALUES (@wareId,@startCityId,@destCityId,@startTime,@commandPrice,@customerID,@commandStatus)",
                            Database.sqlCon);
            try
            {
                cmd.Parameters.Add("@wareId", SqlDbType.Int).Value = command.WareId;
                cmd.Parameters.Add("@startCityId", SqlDbType.Int).Value = fromCityId;
                cmd.Parameters.Add("@destCityId", SqlDbType.Int).Value = toCityId;
                cmd.Parameters.Add("@startTime", SqlDbType.DateTime).Value = DateTime.Today.AddDays(days);
                cmd.Parameters.Add("@commandPrice", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = command.UserId;
                cmd.Parameters.Add("@commandStatus", SqlDbType.Int).Value = command.CommandStatus;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void updateCommandInDb(Command command,int fromCityId)
        {
            SqlCommand cmd = new SqlCommand("UPDATE commands SET destCityId=@regionId WHERE commandId=@cmdId",
                Database.sqlCon);
            try
            {
                cmd.Parameters.Add("@regionId", SqlDbType.Int).Value = fromCityId;
                cmd.Parameters.Add("@cmdId", SqlDbType.Int).Value = command.CommandId;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void splitCommand(Command command)
        {
            Database.sqlCon.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            string startRegion = "", destRegion = " ";
            int startRegionId = 0, destRegionId = 0;

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM cities", Database.sqlCon);
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
            if (startRegion == destRegion)
            {
                //split into 2
                if ((command.DestCityId!=destRegionId)&&(command.StartCityId!=startRegionId))
                {
                    //update the commands- start -> center
                    updateCommandInDb(command, startRegionId);
                    //creating new command  center -> destionation
                    insertCommandIntoDb(command, startRegionId, command.DestCityId, 1);
                }
            }
            else
            {
                //split into 3 
                if (command.StartCityId != startRegionId)
                {
                    //update the commands- start -> center
                    updateCommandInDb(command, startRegionId);
                }
                //command -- center to center
                if ((command.StartCityId != startRegionId) || (command.DestCityId != destRegionId))
                {
                    insertCommandIntoDb(command, startRegionId, destRegionId, 1);
                }
                
                if (destRegionId != command.DestCityId) // if the destination is not the regionCenter
                {
                    //command -- center -> destionation
                    insertCommandIntoDb(command, destRegionId, command.DestCityId, 2);
                }
            }
            Database.sqlCon.Close();
        }

        private List<Van> getVansOrdered(int regionId)
        {
            //getting the vans ordered by the loadCapacity*loadCapPallet

            Database.sqlCon.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            List<Van> vansList = new List<Van>();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vans WHERE regionId = "+regionId+" AND vanStatus=1 ORDER BY loadCapKg*loadCapPallet DESC",
                Database.sqlCon);
            //getting the dataset from the adapter
            da.Fill(ds, "vans");
            dt = ds.Tables["vans"];
            //closing the connection

            foreach (DataRow dr in dt.Rows)
            {
                Van van = new Van();

                van.Consumption = (int)dr["consumption"];
                van.LoadCapKg = (long)dr["loadCapKg"];
                van.LoadCapPallet = (int)dr["loadCapPallet"];
                van.VanId = (int)dr["vanId"];
                van.VanName = (string)dr["vanName"];
                van.Speed = (int)dr["speed"];
                van.VanStatus = (int)dr["vanStatus"];
                van.Driver=(string)dr["driver"];
                van.RegionId=(int)dr["regionId"];

                vansList.Add(van);

            }
            Database.sqlCon.Close();
            return vansList;
        }


        private List<City> getRegions()
        {
            //database =new Database();
            Database.connect();
            Database.sqlCon.Open();
            

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            List<City> regions = new List<City>();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM cities WHERE cityName LIKE region",
                Database.sqlCon);
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

            Database.sqlCon.Close();
            return regions;

        }


        private void getCommandsSeparately()
        {
            //getting the interRegion commands

            //selecting from the cities the centers

            //database.SqlCon.Open();
            
            //getting yesterdays commands List
            List<Command> commands=getCommandsList(getUnselectedCommands());

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

                List<Command> divideCmd = new List<Command>();

                Ware wr=new Ware();

                foreach (Command command in commands)
                {
                    
                    if (region.CityId == command.DestCityId)
                    {
                        collectCmd.Add(command);
                        wr=getWare(command.WareId);
                        //commands.Remove(command);
                    }

                    if (region.CityId == command.StartCityId)
                    {
                        wr=getWare(command.WareId);
                        divideCmd.Add(command);
                        //commands.Remove(command);
                    }
                }

                //adding the list of commands for each region and also the list of wares

                rj.RegionId = region.CityId;
                rj.RegionName = region.CityName;
                rj.CollectCommandsList= collectCmd;

                rj.DivideCommandsList = divideCmd;

                jobForRegions.Add(rj);
            }
            //END of command separatization

            Database.sqlCon.Close();

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
                Database.sqlCon);
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

        private List<Command> addingWareToCommand(List<Command> commandList)
        {
            foreach (Command command in commandList)
            {
                Ware ware;
                ware = getWare(command.WareId);
                
                command.Ware = ware;
            }
            return commandList;
        }

        private List<Command> sortingCommandByWare(List<Command> commandList)
        {
            addingWareToCommand(commandList);
            //sorting the List by the ware---
            commandList = commandList.OrderByDescending(x => x.Ware.WeightPerPallet * x.Ware.NrOfPallets * x.Ware.NrOfPallets)
                  .ToList();
            //commandList.Sort();
            return commandList;
        }

        private List<Command> addingWaresToVan(List<Command> commandList, int regionId)
        {
            List<Van> vanList;
            //getting the vans from that region 
            vanList = getVansOrdered(regionId);
            if (vanList.Count == 0)
            {
                //there is no available van
                return commandList;
            }

            int i=0;

            int maxCapKg = 0;
            int maxCapP = 0;

            foreach (Command command in commandList)
            {

                //getting each command and adding to a van
                // till the van is full

                int commandCapacity =command.Ware.NrOfPallets;
                int commandTotalKg=command.Ware.WeightPerPallet * command.Ware.NrOfPallets;
                long vanKg = vanList[i].LoadCapKg;
                int vanPallets = vanList[i].LoadCapPallet;


                //firstly we got the total kg than the "weight" of the ware
                //if ((filled + commandCapacity) < maxVanCapacity)

                if ((maxCapKg+commandTotalKg<=vanKg)&&(maxCapP+commandCapacity<=vanPallets))
                {
                    maxCapKg += commandTotalKg;
                    maxCapP += command.Ware.NrOfPallets;
                    //filling also the database and the list
                    fillCommandsVanChangeStatus(vanList[i].VanId, command.CommandId);
                    command.VanId = vanList[i].VanId;
                    command.CommandStatus = 1;
                }
                else
                {
                    if (i < vanList.Count - 1)
                    {
                        i++;
                        
                        maxCapKg = 0;
                        maxCapP = 0;

                        maxCapKg += commandTotalKg;
                        maxCapP += command.Ware.NrOfPallets;
                        //filling the database and also the list
                        fillCommandsVanChangeStatus(vanList[i].VanId, command.CommandId);
                        command.VanId = vanList[i].VanId;
                        command.CommandStatus = 1;
                    }
                    else
                    {
                        break;
                        //if it arrives here== there is no more van
                        //it needs to be checked if the other commands can be put into here or other 
                    }
                }
            }
            return commandList;
        }

        private void fillCommandsVanChangeStatus(int vanId, int commandId)
        {
            //putting "ware into a van"==filling van field in command; in DATABASE!!!
            Database.sqlCon.Open();
            SqlCommand cmd = new SqlCommand("UPDATE commands SET vanId=@vanId, commandStatus=1  WHERE commandId=@cmdId",
                Database.sqlCon);
            try
            {
                cmd.Parameters.Add("@vanId", SqlDbType.Int).Value = vanId;
                cmd.Parameters.Add("@cmdId", SqlDbType.Int).Value = commandId;
                cmd.ExecuteNonQuery();
                //updating also the van status--it becomes busy-2
                cmd = new SqlCommand("UPDATE vans SET vanStatus=2 WHERE vanId=@vanId", Database.sqlCon);
                try
                {
                    cmd.Parameters.Add("@vanId", SqlDbType.Int).Value = vanId;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Database.sqlCon.Close();


        }

        private List<City> getCitiesInRegion(string regionName)
        {
            //getting cities from the region

            //database =new Database();
            Database.connect();
            Database.sqlCon.Open();

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            List<City> regions = new List<City>();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM cities WHERE region LIKE "+regionName,
                Database.sqlCon);
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

            Database.sqlCon.Close();
            return regions;


        }

        private void shortestPath(List<Command> commandList, int type)
        {
            //getting the cities which are in the list of commands
            //type refers to inter collect--1 or divide--2
        }

        private string getUserName(int userId)
        {
            Database.sqlCon.Open();

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            User city = new User();

            SqlDataAdapter da = new SqlDataAdapter("SELECT firstName,lastName FROM users WHERE userId= " + userId, Database.sqlCon);
            //getting the dataset from the adapter

            da.Fill(ds, "users");
            dt = ds.Tables["users"];
            //closing the connection
            string name=" ";
            foreach (DataRow dr in dt.Rows)
            {
                name = (string)dr["firstName"]+" " +(string)dr["lastName"];
            }

            Database.sqlCon.Close();
            return name;

        }


        private City getCity(int cityId)
        {
            Database.sqlCon.Open();

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            City city = new City();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM cities WHERE cityId= " + cityId,Database.sqlCon);
            //getting the dataset from the adapter

            da.Fill(ds, "cities");
            dt = ds.Tables["cities"];
            //closing the connection
            foreach (DataRow dr in dt.Rows)
            {           
                city.CityId = (int)dr["cityId"];
                city.CityName = (string)dr["cityName"];
                city.Region = (string)dr["region"];
            }

            Database.sqlCon.Close();
            return city;
        }

        private string getDriverName(int vanId)
        {
            Database.sqlCon.Open();

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT driver FROM vans WHERE vanId= " + vanId, Database.sqlCon);
            //getting the dataset from the adapter

            da.Fill(ds, "vans");
            dt = ds.Tables["vans"];
            //closing the connection
            string name = " ";
            foreach (DataRow dr in dt.Rows)
            {
                name = (string)dr["driver"];
            }

            Database.sqlCon.Close();
            return name;
        }

        public DataTable convertToDatatable<T>(List<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                switch (prop.Name.ToString())
                {
                    case "StartCityId": table.Columns.Add("startCity", typeof(string));
                        break;
                    case "DestCityId": table.Columns.Add("destCity", typeof(string));
                        break;
                    case "UserId": table.Columns.Add("UserName", typeof(string));
                        break;
                        case "Ware": //do nothing, it does not appears there
                            break;
                    default: table.Columns.Add(prop.Name, prop.PropertyType); break;
                }
            }
            object[] values = new object[props.Count-1];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    //MessageBox.Show(props[i].ToString());

                    switch (props[i + 1].Name.ToString())
                    {
                        case "StartCityId": values[i] = getCity((int)props[i + 1].GetValue(item)).CityName;
                            break;
                        case "DestCityId": values[i] = getCity((int)props[i + 1].GetValue(item)).CityName;
                            break;
                        case "UserId": values[i] = getUserName((int)props[i + 1].GetValue(item));
                            break;
                        case "DriverId": values[i] = getDriverName((int)props[i + 1].GetValue(item));
                            break;

                        default: values[i] = props[i + 1].GetValue(item); break;
                    }
                }
                table.Rows.Add(values);
            }
            return table;
        }
        //
        //
        //
        //
        //
        //
        //
        //these functions are desing related

        public void dataGridColor(DataGridView dataGridView1)
        {
            //each van has a different color
            Random random = new Random();
            //get the first van
            int vanId = Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value);
            Color color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (vanId == 0)
                {
                    color = Color.White;
                }
                else
                {
                    if (Convert.ToInt32(row.Cells[2].Value) == vanId)
                    {
                        row.DefaultCellStyle.BackColor = color;
                    }
                    else
                    {
                        vanId = Convert.ToInt32(row.Cells[2].Value);
                        color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                        row.DefaultCellStyle.BackColor = color;
                    }
                }
            }
        }

        public void updateDataTable(ListBox lstType,ListBox lstRegions, DataGridView dataGridView1)
        {
            try
            {
                List<Command> cmdList = new List<Command>();
                foreach (RegionsJob region in RegionsJobs)
                {
                    if (region.RegionName == lstRegions.SelectedItem.ToString())
                    {
                        if (lstType.SelectedItem.ToString() == "intern-Collect")
                        {
                            cmdList = region.CollectCommandsList;
                        }
                        else
                        {
                            cmdList = region.DivideCommandsList;
                        }
                    }
                }
                dataGridView1.DataSource = convertToDatatable(cmdList);
                dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridColor(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateDataTableExtern(ListBox lstType, ListBox lstRegions,DataGridView dataGridView1)
        {
            try
            {
                string opt = lstType.SelectedItem.ToString();
                switch (opt)
                {
                    case "extern":
                        lstRegions.Visible = false;
                        dataGridView1.DataSource = convertToDatatable(ExternCommands);
                        break;
                    case "intern-Collect":
                        lstRegions.Visible = true;
                        break;
                    case "intern-Divide":
                        lstRegions.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }

}
