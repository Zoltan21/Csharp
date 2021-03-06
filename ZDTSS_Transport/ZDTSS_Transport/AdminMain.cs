﻿using System;
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
                allCommands.WindowState = FormWindowState.Maximized;
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


            JobController jobController=new JobController();

            if (morningJobs == null)
            {
                morningJobs = new Jobs(jobController);
                morningJobs.MdiParent = this;
                morningJobs.FormClosed += new FormClosedEventHandler(morningJobs_FormClosed);
                morningJobs.Show();
                morningJobs.WindowState = FormWindowState.Maximized;
            }
            else
            {
                morningJobs.Activate();
                //morningJobs.Show();
            }
        }

        void morningJobs_FormClosed(object sender, FormClosedEventArgs e)
        {
            morningJobs=null;
            //throw new NotImplementedException();
        }

        private void pricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prices allPrices = new Prices(adminController);
            allPrices.MdiParent = this;
            //allPrices.FormClosed += new FormClosedEventHandler(allPrices_FormClosed);
            allPrices.WindowState = FormWindowState.Maximized;
            allPrices.Show();

        }


        private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients allClients = new Clients(adminController);
            allClients.MdiParent = this;
            allClients.WindowState = FormWindowState.Maximized;
            allClients.Show();
        }

        private void manageCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminManageCars cars = new AdminManageCars();
            cars.MdiParent = this;
            cars.Show();
        }

    }
}
