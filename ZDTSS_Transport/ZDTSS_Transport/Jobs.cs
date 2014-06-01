using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZDTSS_Transport
{
    public partial class Jobs : Form
    {
        private JobController jobController;
        public Jobs(JobController jobC)
        {
            jobController = jobC;
            InitializeComponent();
            foreach (City regionCity in jobController.Regions)
            {
                lstRegions.Items.Add(regionCity.CityName);
            }
            jobController.commandsSplitting();
        }

        private void lstRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobController.updateDataTable(lstType, lstRegions, dataGridView1);
        }

        private void lstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobController.updateDataTableExtern(lstType,lstRegions,dataGridView1);
        }

        private void btnAddVans_Click(object sender, EventArgs e)
        {
            jobController.viewMorningJobs();
            jobController.updateDataTable(lstType, lstRegions, dataGridView1);
        }
    }
}
