using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class RegionsJob
    {
        private string regionName;
        
        private List<Command> collectCommandsList;
        private List<Command> divideCommandsList;

        private List<Ware> collectWaresList;
        private List<Ware> divideWaresList;


        public List<Command> CollectCommandsList
        {
            get { return collectCommandsList; }
            set { collectCommandsList = value; }
        }

        public string RegionName
        {
            get { return regionName; }
            set { regionName = value; }
        }

        public List<Command> DivideCommandsList
        {
            get { return divideCommandsList; }
            set { divideCommandsList = value; }
        }

        public List<Ware> CollectWaresList
        {
            get { return collectWaresList; }
            set { collectWaresList = value; }
        }

        public List<Ware> DivideWaresList
        {
            get { return divideWaresList; }
            set { divideWaresList = value; }
        }
    }
}
