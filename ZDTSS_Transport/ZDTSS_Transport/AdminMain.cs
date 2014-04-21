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
        public AdminMain()
        {
            InitializeComponent();
        }

      
                
        private void manageCommandsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pCommands.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pCommands.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditCommand ed = new EditCommand();
            ed.Show(this);
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewCommand nc = new NewCommand();
            nc.Show(this);
            this.Hide();
        }

        private void changePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pPrices.Visible = true;
        }

        private void btnpClose_Click(object sender, EventArgs e)
        {
            pPrices.Visible = false;
        }

        private void btnrClose_Click(object sender, EventArgs e)
        {
            pRoutes.Visible = false;
        }

        private void addRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pRoutes.Visible = true;
        }

        private void allCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
