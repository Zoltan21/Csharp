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
        private AdminController adminController;
        public Jobs(AdminController adminC)
        {
            InitializeComponent();
            adminController = adminC;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminController.viewMorningJobs();
        }

    }
}
