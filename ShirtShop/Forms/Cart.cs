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
    public partial class Cart : Form
    {
        public Cart()
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
    }
}
