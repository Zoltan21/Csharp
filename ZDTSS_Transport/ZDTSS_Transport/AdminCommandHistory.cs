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
    public partial class AdminCommandHistory : Form
    {
        public AdminCommandHistory()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdHistoryHomeButton_Click(object sender, EventArgs e)
        {
            //jumps back to home admin screen from command history
            this.Hide();
        }
    }
}
