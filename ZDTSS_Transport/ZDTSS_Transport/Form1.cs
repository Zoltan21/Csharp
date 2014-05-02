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
        Main main;
        AdminMain adminMain;
        User user;
        Database database;
        private AuthentficationController authController;

        public Login( Database database, User user)
        {
            InitializeComponent();
            this.user = user;
            this.database = database;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register(user);
            register.Show(this);
            this.Hide();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //it instantietate just one type of user or admin or client,, using authentification controller --> adminMain and adminController
                
            //for Stoica --> here you have to use the methods in the AuthentificationController
            authController=new AuthentficationController();
            authController.login(textBox1.Text,textBox2.Text);
            AdminController adminController=new AdminController(database);
            adminMain=new AdminMain(adminController);
            adminMain.Show(this);
            this.Hide();
        }

        //private bool UserValidate()
        //{
        //    bool result;
        //    String username = textBox1.Text;
        //    String password = textBox2.Text;

        //    //SqlConnection databaseCon = new SqlConnection(@"Data Source=NAGYZE-PC\SQLEXPRESS; Initial Catalog=Transport;Integrated Security=True");
        //    //SqlCommand dbCom = databaseCon.CreateCommand();
        //    //databaseCon.Open();
        //    //dbCom.CommandText = "SELECT * FROM users WHERE username='" + username + "' AND password='"+password+"'";
        //    //SqlDataReader dataRead = dbCom.ExecuteReader();

        //    result = dataRead.Read();//return true if the set is not empty or false
        //    dataRead.Close();

        //    return result;  
        //}
    }
}
