using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void AdminManageCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zDTSS_TransportDataSet.vans' table. You can move, or remove it, as needed.
            this.vansTableAdapter.Fill(this.zDTSS_TransportDataSet.vans);
            // This part fills the DataGridView with the content of the table "vans"
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=DAROACH-PC\SQLEXPRESS;Initial Catalog= ZDTSS_Transport; Integrated Security=True ";
            sqlCon.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vans", sqlCon);
            da.Fill(ds, "vans");
            sqlCon.Close();
            CarsDataGrid.DataSource = ds.Tables["vans"];
        }

        //Calls the confirmation screen witch will call the 'AddCar' function from Admin.cs
        private void ManageCarsAddButton_Click(object sender, EventArgs e)
        {
            CarConfirmScreen addCar = new CarConfirmScreen("New Car","AddCar",vid,CarNameBox.Text.ToString(),CarSpeedBox.Text.ToString(),CarWeightBox.Text.ToString(),CarVolumeBox.Text.ToString(),CarConsumptionBox.Text.ToString(),CarStatusBox.Text.ToString());
            addCar.Show(this);
            this.Hide();
        }
        //Calls the confirmation screen witch will call the 'UpdateCar' function from Admin.cs
        private void ManageCarsUpdateButton_Click(object sender, EventArgs e)
        {
            CarConfirmScreen updateCar = new CarConfirmScreen("Update Car", "UpdateCar", vid, CarNameBox.Text.ToString(), CarSpeedBox.Text.ToString(), CarWeightBox.Text.ToString(), CarVolumeBox.Text.ToString(), CarConsumptionBox.Text.ToString(), CarStatusBox.Text.ToString());
            updateCar.Show(this);
            this.Hide();
        }

        //Calls the confirmation screen witch will call the 'DeleteCar' function from Admin.cs
        //Deletion will be executed by "vanId" column
        private void ManageCarsDeleteButton_Click(object sender, EventArgs e)
        {
            CarConfirmScreen updateCar = new CarConfirmScreen("Delete Car", "DeleteCar", vid, CarNameBox.Text.ToString(), CarSpeedBox.Text.ToString(), CarWeightBox.Text.ToString(), CarVolumeBox.Text.ToString(), CarConsumptionBox.Text.ToString(), CarStatusBox.Text.ToString());
            updateCar.Show(this);
            this.Hide();
        }
        //This part fills the textboxes with the data from the selected row.
        private void CarsDataGrid_SelectionChanged_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in CarsDataGrid.SelectedRows)
            {
                int vanID = row.Index;
                vid =CarsDataGrid[0,vanID].Value.ToString();
                string name = CarsDataGrid[1, vanID].Value.ToString();
                CarNameBox.Text = name;
                CarSpeedBox.Text = CarsDataGrid[2, vanID].Value.ToString();
                CarWeightBox.Text = CarsDataGrid[3, vanID].Value.ToString();
                CarVolumeBox.Text = CarsDataGrid[4, vanID].Value.ToString();
                CarConsumptionBox.Text = CarsDataGrid[5, vanID].Value.ToString();
                CarStatusBox.Text = CarsDataGrid[6, vanID].Value.ToString();
            } 
        }
    }
}
