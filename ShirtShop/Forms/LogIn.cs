using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



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
            Enum typeOfUser = ShirtShop.Validate.CheckLoggedIn(txtUserName.Text, txtPassWord.Text);

            if (true)
            {
                
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
