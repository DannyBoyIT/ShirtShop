using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShirtShop.Forms;

namespace ShirtShop
{
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
        }

        private void lstItemsInCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddItem.Visible = true;
            btnRemoveItem.Visible = true;
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            lstItemsInCart.Items.Clear();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            FrmCashRegister newCashRegister = new FrmCashRegister();
            newCashRegister.Show();
        }
    }
}
