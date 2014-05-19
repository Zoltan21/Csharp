using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ZDTSS_Transport
{
    public partial class Main : Form
    {
        ClientController clientController;
        User user;
        public Main(ClientController clientController, User user)
        {
            InitializeComponent();
            this.clientController = clientController;
            this.user = user;
        }

        NewCommand newCommand;

        private void addNewCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newCommand == null)
            {
                newCommand = new NewCommand(clientController, user);
                newCommand.MdiParent = this;
                newCommand.FormClosed += new FormClosedEventHandler(newCommand_FormClosed);
                newCommand.Show();
            }
            else
            {
                newCommand.Activate();
            }
        }

        void newCommand_FormClosed(object sender, FormClosedEventArgs e)
        {
            newCommand = null;
            //throw new NotImplementedException();
        }


        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form EditProfile = new EditProfile(user);
            EditProfile.MdiParent = this;
            EditProfile.Show();
        }

        private void editCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManageCommand = new ManageCommands();
            ManageCommand.MdiParent = this;
            ManageCommand.Show();
        }

        private void commandStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //showing the command status
            ViewStatus viewStatus =new ViewStatus(user);
            viewStatus.MdiParent = this;
            viewStatus.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\a\Documents\GitHub\Csharp\helppdf.pdf");
        }

    }
}
