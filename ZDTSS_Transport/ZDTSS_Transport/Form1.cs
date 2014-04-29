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
        private User user=new User();

        Main main = new Main();
        private Controller controller;
        //AdminController adminController=new AdminController(database);
        AdminMain adminMain=new AdminMain();

        public Login(Controller ctr)
        {
            InitializeComponent();
            controller = ctr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register(user);
            register.Show(this);
            this.Hide();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //this button is responsible for the Login

           // if (UserValidate())
           // {
                
                adminMain.Show(this);
                this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("ERROR! Username or Password is not correct!");
            //}


        }

        private void Login_Load(object sender, EventArgs e)
        {

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
