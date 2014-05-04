﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//I created this form for confirmation of the operation over the DB in "vans" table
//If you click "Confirm", the program calls the respective function(add, update, delete) from Admin.cs - Simon
namespace ZDTSS_Transport
{
    public partial class CarConfirmScreen : Form
    {
        AdminController controller = new AdminController();
        string grBox;
        string opt;
        string vanID;
        string carName;
        string carSpeed;
        string carWeight;
        string carVolume;
        string carConsumption;
        string carStatus;
        public CarConfirmScreen(string groupBoxName,string option,string id,string name, string speed, string weight, string volume, string consumption, string status)
        {
            grBox = groupBoxName;
            opt = option;
            vanID = id;
            carName = name;
            carSpeed = speed;
            carWeight = weight;
            carVolume = volume;
            carConsumption = consumption;
            carStatus = status;
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            controller.manageCars(opt,vanID, nameLabel.Text.ToString(), speedLabel.Text.ToString(), weightLabel.Text.ToString(), volumeLabel.Text.ToString(), consumptionLabel.Text.ToString(), statusLabel.Text.ToString());
            AdminManageCars manageCars = new AdminManageCars();
            manageCars.Show(this);
            this.Hide();
        }

        private void DenyButton_Click(object sender, EventArgs e)
        {
            AdminManageCars manageCars = new AdminManageCars();
            manageCars.Show(this);
            this.Hide();
        }

        private void CarConfirmScreen_Load(object sender, EventArgs e)
        {
            groupBox1.Name = grBox;
            nameLabel.Text = carName;
            speedLabel.Text = carSpeed;
            weightLabel.Text = carWeight;
            volumeLabel.Text = carVolume;
            consumptionLabel.Text = carConsumption;
            statusLabel.Text = carStatus;
        }
    }
}
