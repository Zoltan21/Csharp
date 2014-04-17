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
    public partial class ManageCommands : Form
    {
        public ManageCommands()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Form EditCommand = new EditCommand();
            EditCommand.MdiParent = this.MdiParent;
            EditCommand.Show();
        }
    }
}
