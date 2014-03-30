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
    public partial class NewCommand : Form
    {
        public NewCommand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportCommand reportCom = new ReportCommand(); //moving to the next form
            
            reportCom.Show(); //showing
            reportCom.MdiParent = this.MdiParent; //getting this new form under the Main parent
            this.Hide(); //hiding this 
        }
    }
}
