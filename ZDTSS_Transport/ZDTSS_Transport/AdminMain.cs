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

        private Jobs morningJobs;
        private Commands allCommands;

        public AdminMain(AdminController adminController)
        {
            InitializeComponent();
            this.adminController = adminController;
        }     
       
        

        private void manageCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (allCommands == null)
            {
                allCommands =new Commands(adminController);
                allCommands.MdiParent = this;
                allCommands.FormClosed += new FormClosedEventHandler(allCommands_FormClosed);
                allCommands.Show();
            }
            else
            {
                allCommands.Activate();
            }
        }
        void allCommands_FormClosed(object sender, FormClosedEventArgs e)
        {
            allCommands = null;
            //throw new NotImplementedException();
        }

        private void morningJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            JobController jobController=new JobController(adminController.Database);

            if (morningJobs == null)
            {
                morningJobs = new Jobs(jobController);
                morningJobs.MdiParent = this;
                morningJobs.FormClosed += new FormClosedEventHandler(morningJobs_FormClosed);
                morningJobs.Show();
            }
            else
            {
                morningJobs.Activate();
            }
        }

        void morningJobs_FormClosed(object sender, FormClosedEventArgs e)
        {
            morningJobs = null;
            //throw new NotImplementedException();
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
