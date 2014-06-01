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
        Command command = new Command();
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
            if (tb_id.Text.Equals("") && tb_vanid.Text.Equals("") && tb_wareid.Text.Equals("") && tb_originid.Text.Equals("") && tb_destinationid.Text.Equals("") && tb_time.Text.Equals("") && tb_customerid.Text.Equals("") && tb_status.Text.Equals(""))
            {
                MessageBox.Show("All fields Must be completed");
            }
            else
            {
                Command toEdit = new Command();
                toEdit.CommandId = Convert.ToInt32(tb_id.Text);
                toEdit.VanId = Convert.ToInt32(tb_vanid.Text);
                toEdit.WareId = Convert.ToInt32(tb_wareid.Text);
                toEdit.StartCityId = Convert.ToInt32(tb_originid.Text);
                toEdit.DestCityId = Convert.ToInt32(tb_destinationid.Text);
                toEdit.StartTime = Convert.ToDateTime(tb_time.Text);
                toEdit.UserId = Convert.ToInt32(tb_customerid.Text);
                toEdit.CommandStatus = Convert.ToInt32(tb_status.Text);
                command.updateCommandInDb(toEdit);
                MessageBox.Show("Updated successful");
            }

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

         private void dataGridView1_SelectionChanged(object sender, EventArgs e)
         {

             foreach (DataGridViewRow row in dataGridView1.SelectedRows)
             {

                 tb_id.Text = row.Cells["commandId"].Value.ToString();
                 tb_vanid.Text = row.Cells["vanId"].Value.ToString();
                 tb_wareid.Text = row.Cells["wareId"].Value.ToString();
                 tb_originid.Text = row.Cells["startCityId"].Value.ToString();
                 tb_destinationid.Text = row.Cells["destCityId"].Value.ToString();
                 tb_time.Text = row.Cells["startTime"].Value.ToString();
                 tb_priceid.Text = row.Cells["commandPrice"].Value.ToString();
                 tb_customerid.Text = row.Cells["customerID"].Value.ToString();
                 tb_status.Text = row.Cells["commandStatus"].Value.ToString();
             }

         }
    
         
         
    }
}
