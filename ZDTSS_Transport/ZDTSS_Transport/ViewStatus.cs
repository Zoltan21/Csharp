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
    public partial class ViewStatus : Form
    {
        User user;
        public ViewStatus(User user1)
        {
            InitializeComponent();
            user = user1;
            DataTable dt = user1.viewStatus(user,user.UserId);
            dataGridView1.DataSource = dt;

        }

        private void ViewStatus_Load(object sender, EventArgs e)
        {
            string dodgebrlue = "0";
            string yellow = "1";
            string green = "2";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["commandStatus"].Value.ToString() == dodgebrlue)
                {
                    row.DefaultCellStyle.BackColor = Color.DodgerBlue;
                }
                else if (row.Cells["commandStatus"].Value.ToString() == yellow)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (row.Cells["commandStatus"].Value.ToString() == green)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }
    }
}
