using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class Command : IComparable<Command>
    {
        private int commandId;
        private int vanId;
        private int driverId;
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

        public int DriverId
        {
            get { return driverId; }
            set { driverId = value; }
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
    }
}
