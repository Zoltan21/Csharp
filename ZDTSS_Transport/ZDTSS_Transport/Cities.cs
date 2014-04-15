using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class City
    {
        private int cityId;
        private string cityName;
        private string region;
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        public int CityId
        {
            get { return cityId; }
            set { cityId = value; }
        }
    }
}
