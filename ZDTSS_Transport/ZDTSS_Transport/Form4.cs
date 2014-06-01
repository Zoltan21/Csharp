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
    public partial class Clients : Form
    {
        private AdminController adminController;
        public Clients(AdminController adminC)
        {
            InitializeComponent();
            adminController = adminC;
            DataTable dt = adminC.viewClients();
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {        
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            if (dataGridView1.Rows.Count > 1 && i != dataGridView1.Rows.Count - 1)
            {
                int id = int.Parse(dataGridView1.Rows[i].Cells["userId"].Value.ToString());
                adminController.deleteUser(id);
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows[i].Index);
                MessageBox.Show("Row Deleted");

            }        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tb_id.Text.Equals("") && tb_adminstatus.Text.Equals("") )
            {
                MessageBox.Show("All fields Must be completed");
            }
            else if (tb_adminstatus.Text.Equals("0") || tb_adminstatus.Text.Equals("1"))
            {
                int id = Convert.ToInt32(tb_id.Text);
                int adminStatus = Convert.ToInt32(tb_adminstatus.Text);
                adminController.updateClientStatus(id, adminStatus);
                MessageBox.Show("Updated successful");
            }
    else{
        MessageBox.Show("Status must be 0-Client 1-Admin");
    }
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                tb_id.Text = row.Cells["userId"].Value.ToString();
                tb_adminstatus.Text = row.Cells["status"].Value.ToString();
            }
        }
        
    }
}
