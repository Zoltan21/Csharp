using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class Command
    {
        private int commandId;
        private int vanId;
        private int driverId;
        private int wareId;
        private int startCityId;
        private int destCityId;
        private DateTime startTime;
        private DateTime finishTime;
        private int commandPrice;
        private int userId;

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

        public DateTime FinishTime
        {
            get { return finishTime; }
            set { finishTime = value; }
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
    }
}
