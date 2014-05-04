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
    public partial class AdminMain : Form
    {
        private AdminController adminController;// we just need to use this adminController

        public AdminMain(AdminController adminController)
        {
            InitializeComponent();
            this.adminController = adminController;
        }     
       
        

        private void manageCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commands allCommands = new Commands(adminController);
            allCommands.Show(this);
            this.Hide();
        }

        private void morningJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jobs morningJobs = new Jobs(adminController);
            morningJobs.Show(this);
            this.Hide();
        }

        private void pricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prices allPrices = new Prices(adminController);
            allPrices.Show(this);
            this.Hide();
        }

        private void routesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Routes allRoutes = new Routes(adminController);
            allRoutes.Show(this);
            this.Hide();
        }


    }
}
