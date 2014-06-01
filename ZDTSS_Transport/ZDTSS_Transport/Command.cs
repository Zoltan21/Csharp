using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ZDTSS_Transport
{
    public class Command : IComparable<Command>
    {
        private int commandId;
        private int vanId;
        private int wareId;
        private int startCityId;
        private int destCityId;
        private DateTime startTime;
        private int commandPrice;
        private int userId;
        private int commandStatus;
        private Ware ware;

        public Ware Ware
        {
            get { return ware; }
            set { ware = value; }
        }

        public int CommandStatus
        {
            get { return commandStatus; }
            set { commandStatus = value; }
        }

        public int CommandId
        {
            get { return commandId; }
            set { commandId = value; }
        }

        public int VanId
        {
            get { return vanId; }
            set { vanId = value; }
        }

        public int WareId
        {
            get { return wareId; }
            set { wareId = value; }
        }

        public int StartCityId
        {
            get { return startCityId; }
            set { startCityId = value; }
        }

        public int DestCityId
        {
            get { return destCityId; }
            set { destCityId = value; }
        }

        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        public int CommandPrice
        {
            get { return commandPrice; }
            set { commandPrice = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public int CompareTo(Command other)
        {
            //it sorts the Command by the product of warePallet and NrofPAllets
            return ware.WeightPerPallet * ware.NrOfPallets;
        }
        public void updateCommandInDb(Command command)
        {// updating a command
            Database.sqlCon.Open();
            SqlCommand cmd = new SqlCommand("UPDATE commands SET vanId=@vanId, wareId=@wareId, startCityId=@startCityId ,destCityId=@destCityId, startTime=@startTime, commandPrice=@commandPrice, customerID=@customerID, commandStatus=@commandStatus WHERE commandId=@commandId", Database.sqlCon);
            try
            {
                cmd.Parameters.Add("@commandId", SqlDbType.Int).Value = command.commandId;
                cmd.Parameters.Add("@vanId", SqlDbType.Int).Value = command.vanId;
                cmd.Parameters.Add("@wareId", SqlDbType.Int).Value = command.wareId;
                cmd.Parameters.Add("@startCityId", SqlDbType.Int).Value = command.startCityId;
                cmd.Parameters.Add("@destCityId", SqlDbType.Int).Value = command.destCityId;
                cmd.Parameters.Add("@startTime", SqlDbType.Date).Value = command.startTime;
                cmd.Parameters.Add("@commandPrice", SqlDbType.Int).Value = command.commandPrice;
                cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = command.userId;
                cmd.Parameters.Add("@commandStatus", SqlDbType.Int).Value = command.commandStatus;
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
