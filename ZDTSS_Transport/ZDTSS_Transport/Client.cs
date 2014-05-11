using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ZDTSS_Transport
{
    public class ClientController
    {
        public void addNewCommandIntoDb()
        {

            //adding a new command 
            throw new System.NotImplementedException();
        }

        public Command makeNewCommand(int startCityId, int destCityId, DateTime startTime, int userId, string wareDescript, int weightPerPallet, int nrOfPallets)
        {
            Command cmd=new Command();

            cmd.Ware = makeNewWare(wareDescript,weightPerPallet,nrOfPallets);// it return a ware
            cmd.StartCityId = startCityId;
            cmd.DestCityId = destCityId;
            cmd.StartTime = startTime;
            cmd.UserId = userId;
            cmd.CommandPrice = getPrice(cmd.Ware);

            //none of these are in the database
            return cmd;
        }

        public Ware makeNewWare(string description, int weightPerPallet, int nrOfPallets)
        {
            Ware ware = new Ware();
            ware.Description = description;
            ware.WeightPerPallet = weightPerPallet;
            ware.NrOfPallets = nrOfPallets;

            return ware;
        }

        public void viewCommands()
        {
            throw new System.NotImplementedException();
        }

        public void showHelp()
        {
            throw new System.NotImplementedException();
        }

        public void viewStatus()
        {
            throw new System.NotImplementedException();
        }

        public string getCityName(int cityId)
        {
            //getting the name of the city with the cityId
            Database.sqlCon.Open();

            string cityName="";
            SqlCommand command = new SqlCommand("SELECT * FROM cities WHERE cityId='" + cityId+"'", Database.sqlCon);
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    cityName = dataReader.GetString(1);
                }
                
            }

            Database.sqlCon.Close();
            return cityName;
        }

        public int getCityId(string cityName)
        {
            Database.sqlCon.Open();

            int cityId=0;
            SqlCommand command = new SqlCommand("SELECT * FROM cities WHERE cityName LIKE '" + cityName + "'", Database.sqlCon);
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    cityId = dataReader.GetInt32(0);
                }
            }

            Database.sqlCon.Close();
            return cityId;
        }

        public List<City> getCities()
        {
            Database.sqlCon.Open();

            List<City> cities = new List<City>();
            SqlCommand command = new SqlCommand("SELECT * FROM cities", Database.sqlCon);
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    //getting user object
                    City city = new City();

                    city.CityId = dataReader.GetInt32(0);
                    city.CityName = dataReader.GetString(1);

                    cities.Add(city);
                }
            }

            Database.sqlCon.Close();
            return cities;
        }

        public int getPrice(Ware ware)
        {
            Database.sqlCon.Open();

            int price = 0;
            //selecting the right price
            SqlCommand command = new SqlCommand("SELECT price FROM prices WHERE kgPerPalletFrom<=" + ware.WeightPerPallet + " AND kgPerPalletTo> " + ware.WeightPerPallet, Database.sqlCon);
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    price = dataReader.GetInt32(0);
                }
            }

            Database.sqlCon.Close();
            return price;
        }

        public void insertCommandIntoDb(Command command)
        {
            Database.sqlCon.Open();
            int wareId = insertWareIntoDb(command.Ware);
            SqlCommand cmd =
                        new SqlCommand(
                           "INSERT Into commands(wareId,startCityId,destCityId,startTime,commandPrice,customerID,commandStatus) VALUES (@wareId,@startCityId,@destCityId,@startTime,@commandPrice,@customerID,@commandStatus)",
                            Database.sqlCon);
            try
            {
                cmd.Parameters.Add("@wareId", SqlDbType.Int).Value = wareId;
                cmd.Parameters.Add("@startCityId", SqlDbType.Int).Value = command.StartCityId;
                cmd.Parameters.Add("@destCityId", SqlDbType.Int).Value = command.DestCityId;
                cmd.Parameters.Add("@startTime", SqlDbType.DateTime).Value = command.StartTime;
                cmd.Parameters.Add("@commandPrice", SqlDbType.Int).Value = command.CommandPrice;
                cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = command.UserId;
                cmd.Parameters.Add("@commandStatus", SqlDbType.Int).Value = command.CommandStatus;
                cmd.ExecuteNonQuery();

                Database.sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private int insertWareIntoDb(Ware ware)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO wares(description,weightPerPallet,nrOfPallets) VALUES (@description,@weightPerPallet,@nrOfPallets)", Database.sqlCon);
            try
            {
                cmd.Parameters.Add("@description", SqlDbType.Text).Value = ware.Description;
                cmd.Parameters.Add("weightPerPallet", SqlDbType.Int).Value = ware.WeightPerPallet;
                cmd.Parameters.Add("@nrOfPallets", SqlDbType.Int).Value = ware.NrOfPallets;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //now it needs to get back the wareId

            SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('wares')", Database.sqlCon);
            ware.WareId=Convert.ToInt32(command.ExecuteScalar());

            return ware.WareId;
        }
    }
}
