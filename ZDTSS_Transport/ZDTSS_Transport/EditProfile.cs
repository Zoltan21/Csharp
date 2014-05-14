using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZDTSS_Transport
{
    public partial class EditProfile : Form
    {
        User user;
        public EditProfile(User user)
        {
            InitializeComponent();
            this.user = user;
        }

       

       
      

        private void EditProfile_Load_1(object sender, EventArgs e)
        {
            txtb_first_name.Text = user.FirstName;
            txtb_last_name.Text = user.LastName;
            txtb_telephone.Text = user.PhoneNumber;
            txtb_username.Text = user.UserName;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            User userm = new User();
            userm.FirstName = txtb_first_name.Text;
            userm.LastName = txtb_last_name.Text;
            userm.PhoneNumber = txtb_telephone.Text;
            userm.UserName = txtb_username.Text;
            userm.Status = 0;
            userm.Password = txt_new_password.Text;

            if (txtb_old_password.Text == user.Password.Trim())
            {
                if (txt_new_password.Text == txtb_confirm_password.Text)
                {
                    user.updateUserInDb(userm, user.UserId);
                    MessageBox.Show("Update succesfull");
                }
                else
                    MessageBox.Show("The passwords don't match");
            }
            else
                MessageBox.Show("The old password is incorect (15 characters)");
        }

    
    }
}
