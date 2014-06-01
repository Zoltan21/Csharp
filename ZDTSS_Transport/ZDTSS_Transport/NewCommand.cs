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
    public partial class NewCommand : Form
    {
        ClientController clientController;
        User user;


        public NewCommand(ClientController clientController,User user)
        {
            InitializeComponent();
            this.clientController = clientController;
            this.user = user;
            init();
        }

        private void init()
        {
            //initializing the components
           List<City> cities=clientController.getCities();
            //adding cities to the list
           foreach(City city in cities)
           {
               cmbFromList.Items.Add(city.CityName);
               cmbToList.Items.Add(city.CityName);
           }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int startCityId = clientController.getCityId(cmbFromList.SelectedItem.ToString());
                int destCityId = clientController.getCityId(cmbToList.SelectedItem.ToString());
                Command command = clientController.makeNewCommand(startCityId, destCityId, Convert.ToDateTime(monthCalendar1.SelectionRange.Start.ToString()),
                                 user.UserId, txtDescription.Text, (int)nrKgPerPallet.Value, (int)nrNrOfPallets.Value);
                ReportCommand reportCom = new ReportCommand(command, clientController); //moving to the next form
                reportCom.Show(); //showing
                reportCom.MdiParent = this.MdiParent; //getting this new form under the Main parent
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("ERROR! All the fields has to be completed!");
            }
            //
        
        } //hiding this 

    }
}
