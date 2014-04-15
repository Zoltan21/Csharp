using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class Route
    {
        private int routeId;
        private int fromCityId;
        private int toCityId;
        private int distance;//this will be added in km

        public int RouteId
        {
            get { return routeId; }
            set { routeId = value; }
        }

        public int ToCityId
        {
            get { return toCityId; }
            set { toCityId = value; }
        }

        public int FromCityId
        {
            get { return fromCityId; }
            set { fromCityId = value; }
        }

        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }
    }
}
