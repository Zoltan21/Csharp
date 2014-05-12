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
    public partial class ReportCommand : Form
    {
        Command command;
        ClientController clientController;

        public ReportCommand(Command command, ClientController clientController)
        {
            InitializeComponent();
            this.command = command;
            this.clientController = clientController;

            init(command);
        }

        private void init(Command command)
        {
            txtFromCity.Text = clientController.getCityName(command.StartCityId);
            txtToCity.Text = clientController.getCityName(command.DestCityId);
            txtKgPerPallet.Text = command.Ware.WeightPerPallet.ToString();
            txtNrOfPallets.Text = command.Ware.NrOfPallets.ToString();
            txtDescription.Text = command.Ware.Description;
            txtPickUpDate.Text = command.StartTime.ToString();
            txtDeliveryDate.Text = DateTime.Today.AddDays(4).ToString();// excepting the worst case
            txtPrice.Text = command.CommandPrice.ToString();

        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            //using client controller to save the new Command into the db

            clientController.insertCommandIntoDb(command);
            command = null;
            this.Close();


        }
    }
}
