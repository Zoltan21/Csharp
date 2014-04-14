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
    public partial class AdminMainScreen : Form
    {
        public AdminMainScreen()
        {
            InitializeComponent();
        }
        AdminCommandHistory adminCmdHistory;
        AdminCommandUpdate adminCmdUpdate;
        NewCommand newCmd;

        private void addNewCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Commands - add new command - uses the same form as client
            if (newCmd == null)
            {
                newCmd = new NewCommand();
                newCmd.MdiParent = this;
                newCmd.FormClosed += new FormClosedEventHandler(newCmd_FormClosed);
                newCmd.Show();
            }
            else
            {
                newCmd.Activate();
            }
        }
        void newCmd_FormClosed(object sender, FormClosedEventArgs e)
        {
            newCmd = null;
            //throw new NotImplementedException();
        }

        private void commandHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //command - command history - uses new admin form, because admins can see all customer commands
            if (adminCmdHistory == null)
            {
                adminCmdHistory = new AdminCommandHistory();
                adminCmdHistory.MdiParent = this;
                adminCmdHistory.Show();
            }
            else
            {
                adminCmdHistory.Activate();
            }
        }

        private void updateCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adminCmdUpdate == null)
            {
                adminCmdUpdate = new AdminCommandUpdate();
                adminCmdUpdate.MdiParent = this;
                adminCmdUpdate.Show();
            }
        }
    }
}
