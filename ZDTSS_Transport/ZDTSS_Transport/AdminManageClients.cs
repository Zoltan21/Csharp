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
    public partial class AdminManageClients : Form
    {
        AdminController controller = new AdminController();
        string uid;

        public AdminManageClients()
        {
            InitializeComponent();
        }

        private void AdddButton_Click(object sender, EventArgs e)
        {
            string fName = UserFirstNameBox.Text.ToString();
            string lName = UserLastNameBox.Text.ToString();
            string phone = UserPhoneBox.Text.ToString();
            string uName = UserUsernameBox.Text.ToString();
            string pass = UserPasswordBox.Text.ToString();
            string status = UserStatusBox.Text.ToString();
            controller.manageClients("AddClient", uid, fName, lName, phone, uName, pass, status);
            DataSet users = controller.getUsers();
            dataGridView1.DataSource = users.Tables["users"];
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string fName = UserFirstNameBox.Text.ToString();
            string lName = UserLastNameBox.Text.ToString();
            string phone = UserPhoneBox.Text.ToString();
            string uName = UserUsernameBox.Text.ToString();
            string pass = UserPasswordBox.Text.ToString();
            string status = UserStatusBox.Text.ToString();
            controller.manageClients("UpdateClient", uid, fName, lName, phone, uName, pass, status);
            DataSet users = controller.getUsers();
            dataGridView1.DataSource = users.Tables["users"];
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string fName = UserFirstNameBox.Text.ToString();
            string lName = UserLastNameBox.Text.ToString();
            string phone = UserPhoneBox.Text.ToString();
            string uName = UserUsernameBox.Text.ToString();
            string pass = UserPasswordBox.Text.ToString();
            string status = UserStatusBox.Text.ToString();
            controller.manageClients("DeleteClient", uid, fName, lName, phone, uName, pass, status);
            DataSet users = controller.getUsers();
            dataGridView1.DataSource = users.Tables["users"];
        }

        private void AdminManageClients_Load(object sender, EventArgs e)
        {
            DataSet users = controller.getUsers();
            dataGridView1.DataSource = users.Tables["users"];
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int vanID = row.Index;
                uid = dataGridView1[0, vanID].Value.ToString();
                string name = dataGridView1[1, vanID].Value.ToString();
                UserFirstNameBox.Text = name;
                UserLastNameBox.Text = dataGridView1[2, vanID].Value.ToString();
                UserPhoneBox.Text = dataGridView1[3, vanID].Value.ToString();
                UserUsernameBox.Text = dataGridView1[4, vanID].Value.ToString();
                UserPasswordBox.Text = dataGridView1[5, vanID].Value.ToString();
                UserStatusBox.Text = dataGridView1[6, vanID].Value.ToString();
            } 
        }
    }
}
