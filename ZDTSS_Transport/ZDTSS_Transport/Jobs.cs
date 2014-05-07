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

            jobController.viewMorningJobs();

        }

        private void lstRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Command> cmdList=new List<Command>();
                foreach (RegionsJob region in jobController.RegionsJobs)
                {
                    if (region.RegionName == lstRegions.SelectedItem.ToString())
                    {
                        if (lstType.SelectedItem.ToString() == "intern-Collect")
                        {
                            cmdList = region.CollectCommandsList;
                        }
                        else
                        {
                            cmdList = region.DivideCommandsList;
                        }
                    }
                }
                dataGridView1.DataSource = jobController.convertToDatatable(cmdList);

            }
            catch (Exception)
            {

            }
        }

        private void Jobs_Load(object sender, EventArgs e)
        {
            //loading the regions list:
        }

        private void lstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if selected index is changed
                string opt=lstType.SelectedItem.ToString();

                //MessageBox.Show(opt);

                switch (opt)
                {
                    case "extern":
                        lstRegions.Visible=false;
                        dataGridView1.DataSource = jobController.convertToDatatable(jobController.ExternCommands);
                        break;
                    case "intern-Collect":
                        lstRegions.Visible=true;
                        break;
                    case "intern-Divide":
                        lstRegions.Visible=true;
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

    }
}
