using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZDTSS_Transport
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void radio_show_password_CheckedChanged(object sender, EventArgs e)
        {
            txtb_curent_password.PasswordChar = '\0';
        }

    
    }
}
