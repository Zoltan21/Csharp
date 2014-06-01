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
                dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridColor()
        {
            //each van has a different color
            Random random = new Random();
            //get the first van
            int vanId = Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value);
            Color color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[3].Value) == vanId)
                {
                    row.DefaultCellStyle.BackColor = color;
                }
                else
                {
                    //get the next van
                    if (Convert.ToInt32(row.Cells[1].Value) != 0)
                    {
                        vanId = Convert.ToInt32(row.Cells[3].Value);
                        color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                        row.DefaultCellStyle.BackColor = color;
                    }
                    else
                    {
                        color = Color.White;
                    }

                }
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

        private void btnAddVans_Click(object sender, EventArgs e)
        {
            //adding vans to the commands (Put wares into vans)

            jobController.viewMorningJobs();
        }

    }
}
