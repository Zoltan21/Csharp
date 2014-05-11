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
    public partial class Register : Form
    {
        AuthentficationController authController;

        public Register(AuthentficationController authController)
        {
            this.authController = authController;
            InitializeComponent();
        }
                
        private void btnRegister_Click(object sender, EventArgs e)
        {
            authController.register(txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, txtPasswordAgain.Text,txtPhoneNumber.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

    }
}
