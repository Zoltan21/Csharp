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
    public partial class Prices : Form
    {
        private AdminController adminController;
        public Prices(AdminController adminC)
        {
            InitializeComponent();
            adminController = adminC;
            DataTable dt = adminC.viewPrices();
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tb_id.Text.Equals("") && tb_price.Text.Equals(""))
            {
                MessageBox.Show("All fields Must be completed");
            }
            else
            {
                int id = Convert.ToInt32(tb_id.Text);
                int price = Convert.ToInt32(tb_price.Text);
                adminController.updatePrice(id, price);
                MessageBox.Show("Updated successful");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            if (dataGridView1.Rows.Count > 1 && i != dataGridView1.Rows.Count - 1)
            {
                int id = int.Parse(dataGridView1.Rows[i].Cells["priceId"].Value.ToString());
                adminController.deletePrice(id);
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows[i].Index);
                MessageBox.Show("Row Deleted");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                tb_id.Text = row.Cells["priceId"].Value.ToString();
                tb_price.Text = row.Cells["price"].Value.ToString();

            }
        }
    }
}
