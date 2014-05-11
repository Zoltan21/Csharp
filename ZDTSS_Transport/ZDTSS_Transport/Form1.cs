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
    public partial class Login : Form
    {
        User user;
        AuthentficationController authController;

        public Login(User user, AuthentficationController authController)
        {
            InitializeComponent();
            this.user = user;
            this.authController = authController;

        }

        private void adminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Login into the application
            user = authController.login(txtUserName.Text, txtPassword.Text);
            if (user != null)
            {
                if (user.Status == 0)
                {
                    ClientController clientController = new ClientController();
                    Main main=new Main(clientController,user);
                    main.Show(this);
                    main.FormClosed += new FormClosedEventHandler(adminMain_FormClosed);
                    this.Hide();
                }
                else
                {
                    AdminController adminController = new AdminController();
                    AdminMain adminMain = new AdminMain(adminController);
                    adminMain.Show(this);
                    adminMain.FormClosed += new FormClosedEventHandler(adminMain_FormClosed);
                    this.Hide();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register(authController);
            register.Show(this);
            this.Hide();
        }
    }
}
