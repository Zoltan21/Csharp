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
    public partial class AdminManageCars : Form
    {
        AdminController controller = new AdminController();
        string vid;
        public AdminManageCars()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CarConfirmation addCar = new CarConfirmation("New Car", "AddCar", vid, CarNameBox.Text.ToString(), CarSpeedBox.Text.ToString(), CarWeightBox.Text.ToString(), CarVolumeBox.Text.ToString(), CarConsumptionBox.Text.ToString(), CarStatusBox.Text.ToString());
            addCar.Show(this);
            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            CarConfirmation updateCar = new CarConfirmation("Update Car", "UpdateCar", vid, CarNameBox.Text.ToString(), CarSpeedBox.Text.ToString(), CarWeightBox.Text.ToString(), CarVolumeBox.Text.ToString(), CarConsumptionBox.Text.ToString(), CarStatusBox.Text.ToString());
            updateCar.Show(this);
            this.Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CarConfirmation updateCar = new CarConfirmation("Delete Car", "DeleteCar", vid, CarNameBox.Text.ToString(), CarSpeedBox.Text.ToString(), CarWeightBox.Text.ToString(), CarVolumeBox.Text.ToString(), CarConsumptionBox.Text.ToString(), CarStatusBox.Text.ToString());
            updateCar.Show(this);
            this.Hide();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int vanID = row.Index;
                vid = dataGridView1[0, vanID].Value.ToString();
                string name = dataGridView1[1, vanID].Value.ToString();
                CarNameBox.Text = name;
                CarSpeedBox.Text = dataGridView1[2, vanID].Value.ToString();
                CarWeightBox.Text = dataGridView1[3, vanID].Value.ToString();
                CarVolumeBox.Text = dataGridView1[4, vanID].Value.ToString();
                CarConsumptionBox.Text = dataGridView1[5, vanID].Value.ToString();
                CarStatusBox.Text = dataGridView1[6, vanID].Value.ToString();
            } 
        }

        private void AdminManageCars_Load(object sender, EventArgs e)
        {
            DataSet vans = controller.getCars();
            dataGridView1.DataSource = vans.Tables["vans"];
        }
    }
}
