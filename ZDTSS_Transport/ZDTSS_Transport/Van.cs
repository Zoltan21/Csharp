using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class Van
    {
        private int vanId;
        private string vanName;
        private int speed;
        private long loadCapKg;
        private int loadCapPallet;
        private int consumption;
        private int vanStatus;
        private string driver;
        private int regionId;

        public int RegionId
        {
            get { return regionId; }
            set { regionId = value; }
        }

        public string Driver
        {
            get { return driver; }
            set { driver = value; }
        }
        

        public int VanId
        {
            get { return vanId; }
            set { vanId = value; }
        }

        public string VanName
        {
            get { return vanName; }
            set { vanName = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public long LoadCapKg
        {
            get { return loadCapKg; }
            set { loadCapKg = value; }
        }

        public int LoadCapPallet
        {
            get { return loadCapPallet; }
            set { loadCapPallet = value; }
        }

        public int Consumption
        {
            get { return consumption; }
            set { consumption = value; }
        }

        public int VanStatus
        {
            get { return vanStatus; }
            set { vanStatus = value; }
        }
    }
}
