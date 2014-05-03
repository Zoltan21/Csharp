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
    public partial class Commands : Form
    {
        private AdminController adminController;
        public Commands(AdminController adminC)
        {
            InitializeComponent();
            adminController = adminC;
            DataTable dt = adminC.viewCommands();
            dataGridView1.DataSource = dt;
        }      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            if (dataGridView1.Rows.Count > 1 && i != dataGridView1.Rows.Count - 1)
            {
                int id = int.Parse(dataGridView1.Rows[i].Cells["commandId"].Value.ToString());
                adminController.deleteCommand(id);
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows[i].Index);
                MessageBox.Show("Row Deleted");

            }
        }



        
    }
}
