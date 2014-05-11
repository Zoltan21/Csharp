using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class RegionsJob
    {
        private int regionId;
        private string regionName;
      
        private List<Command> collectCommandsList;
        private List<Command> divideCommandsList;

        public string RegionName
        {
            get { return regionName; }
            set { regionName = value; }
        }

        public List<Command> CollectCommandsList
        {
            get { return collectCommandsList; }
            set { collectCommandsList = value; }
        }

        public int RegionId
        {
            get { return regionId; }
            set { regionId = value; }
        }

        public List<Command> DivideCommandsList
        {
            get { return divideCommandsList; }
            set { divideCommandsList = value; }
        }
    }
}
