namespace ShirtShop
{
    partial class frmCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstItemsInCart = new System.Windows.Forms.ListBox();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnContinueShopping = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Din varukorg:";
            // 
            // lstItemsInCart
            // 
            this.lstItemsInCart.FormattingEnabled = true;
            this.lstItemsInCart.ItemHeight = 16;
            this.lstItemsInCart.Location = new System.Drawing.Point(16, 44);
            this.lstItemsInCart.Name = "lstItemsInCart";
            this.lstItemsInCart.Size = new System.Drawing.Size(233, 116);
            this.lstItemsInCart.TabIndex = 1;
            this.lstItemsInCart.SelectedIndexChanged += new System.EventHandler(this.lstItemsInCart_SelectedIndexChanged);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(16, 183);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(233, 33);
            this.btnClearCart.TabIndex = 2;
            this.btnClearCart.Text = "Rensa varukorg";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(16, 239);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(233, 32);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Gå till kassan";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnContinueShopping
            // 
            this.btnContinueShopping.Location = new System.Drawing.Point(315, 240);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(134, 31);
            this.btnContinueShopping.TabIndex = 4;
            this.btnContinueShopping.Text = "Fortsätt shoppa";
            this.btnContinueShopping.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(315, 65);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(104, 31);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Lägg till fler";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Visible = false;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(315, 114);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(104, 31);
            this.btnRemoveItem.TabIndex = 6;
            this.btnRemoveItem.Text = "Ta bort";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Visible = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 295);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnContinueShopping);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.lstItemsInCart);
            this.Controls.Add(this.label1);
            this.Name = "Cart";
            this.Text = "Varukorg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstItemsInCart;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnContinueShopping;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}