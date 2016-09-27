﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShirtShop.Enums; 


namespace ShirtShop
{
    public partial class fmrLogIn : Form
    {
        public fmrLogIn()
        {
            InitializeComponent();
        }

        private void btnLoggIn_Click(object sender, EventArgs e)
        {
            UserTypeEnum typeOfUser = ShirtShop.Validate.CheckLoggedIn(txtUserName.Text, txtPassWord.Text);

            if (typeOfUser == UserTypeEnum.Admin)
            {
                //frmAdmin.Show();
                this.Close();
            }
            else if (typeOfUser == UserTypeEnum.User)
            {
                this.Close();
            }


        }

        private void btnRegisterNewUser_Click(object sender, EventArgs e)
        {
            frmRegister registrateNew = new frmRegister();
            registrateNew.Show();
            this.Close();
        }
    }
}
