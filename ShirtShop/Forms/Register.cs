using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShirtShop
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void lblMobileNumber_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control txtControl in Controls)
            {
                if (txtControl is TextBox)
                {
                    txtControl.Text = "";
                }
            }
        }

        private void btnAlreadyAMember_Click(object sender, EventArgs e)
        {
            fmrLogIn newLogIn = new fmrLogIn();
            newLogIn.Show();
            this.Close();
          
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User newRegistration = new User();

            try
            {
                newRegistration.FirstName = txtFirstName.Text;
                newRegistration.LastName = txtLastName.Text;
                newRegistration.Email = txtEmail.Text;
                newRegistration.Address = txtAdress.Text;
                newRegistration.City = txtCity.Text;
                newRegistration.Telephone = txtTelephone.Text;
                newRegistration.Username = txtUsername.Text;
                newRegistration.Password = txtPassword.Text;

                var AllInputOk = ShirtShop.Validate.CheckUserInput(newRegistration);

                if (AllInputOk)
                {
                    MessageBox.Show("Välkomen! Du har nu registrerat dig!");
                    DatabaseRepository saveUser = new DatabaseRepository();
                    saveUser.CreateUser();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }

        }

    }
}
