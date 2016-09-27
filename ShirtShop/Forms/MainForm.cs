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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void llblLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmrLogIn newLogIn = new fmrLogIn();
           newLogIn.Show();
        }

        private void llblRegisterNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister newFrmRegister = new frmRegister();
            newFrmRegister.Show();
        }

        private void llblShoppingCart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCart newFrmCart = new frmCart();
            newFrmCart.Show();
        }

        private void cmbMan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO write code for all comboboxes
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO Write code for search button
        }
    }
}
