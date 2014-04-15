using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class Ware
    {
        private int wareId;
        private string description;
        private int weightPerPallet;
        private int nrOfPallets;

        public int WareId
        {
            get { return wareId; }
            set { wareId = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int WeightPerPallet
        {
            get { return weightPerPallet; }
            set { weightPerPallet = value; }
        }

        public int NrOfPallets
        {
            get { return nrOfPallets; }
            set { nrOfPallets = value; }
        }
    }
}
