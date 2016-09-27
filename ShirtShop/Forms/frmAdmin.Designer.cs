namespace ShirtShop.Forms
{
    partial class frmAdmin
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
            this.lblWomen = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lblMen = new System.Windows.Forms.Label();
            this.cboChildren = new System.Windows.Forms.ComboBox();
            this.cboWomen = new System.Windows.Forms.ComboBox();
            this.cboMen = new System.Windows.Forms.ComboBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWomen
            // 
            this.lblWomen.AutoSize = true;
            this.lblWomen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblWomen.Location = new System.Drawing.Point(136, 17);
            this.lblWomen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWomen.Name = "lblWomen";
            this.lblWomen.Size = new System.Drawing.Size(37, 17);
            this.lblWomen.TabIndex = 28;
            this.lblWomen.Text = "Dam";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblChildren.Location = new System.Drawing.Point(261, 17);
            this.lblChildren.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(38, 17);
            this.lblChildren.TabIndex = 27;
            this.lblChildren.Text = "Barn";
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMen.Location = new System.Drawing.Point(13, 17);
            this.lblMen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(36, 17);
            this.lblMen.TabIndex = 26;
            this.lblMen.Text = "Herr";
            // 
            // cboChildren
            // 
            this.cboChildren.FormattingEnabled = true;
            this.cboChildren.Items.AddRange(new object[] {
            "Hattar",
            "T-shirts",
            "Skor"});
            this.cboChildren.Location = new System.Drawing.Point(264, 42);
            this.cboChildren.Margin = new System.Windows.Forms.Padding(2);
            this.cboChildren.Name = "cboChildren";
            this.cboChildren.Size = new System.Drawing.Size(110, 24);
            this.cboChildren.TabIndex = 25;
            // 
            // cboWomen
            // 
            this.cboWomen.FormattingEnabled = true;
            this.cboWomen.Items.AddRange(new object[] {
            "Hattar",
            "T-shirts",
            "Skor"});
            this.cboWomen.Location = new System.Drawing.Point(139, 42);
            this.cboWomen.Margin = new System.Windows.Forms.Padding(2);
            this.cboWomen.Name = "cboWomen";
            this.cboWomen.Size = new System.Drawing.Size(110, 24);
            this.cboWomen.TabIndex = 24;
            // 
            // cboMen
            // 
            this.cboMen.FormattingEnabled = true;
            this.cboMen.Items.AddRange(new object[] {
            "Hattar",
            "T-shirts",
            "Skor"});
            this.cboMen.Location = new System.Drawing.Point(11, 42);
            this.cboMen.Margin = new System.Windows.Forms.Padding(2);
            this.cboMen.Name = "cboMen";
            this.cboMen.Size = new System.Drawing.Size(110, 24);
            this.cboMen.TabIndex = 23;
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 16;
            this.lstProducts.Location = new System.Drawing.Point(394, 115);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(452, 276);
            this.lstProducts.TabIndex = 22;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(814, 76);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 22);
            this.txtSearch.TabIndex = 21;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSearch.Location = new System.Drawing.Point(779, 76);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(32, 17);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Sök";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1024, 499);
            this.Controls.Add(this.lblWomen);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.lblMen);
            this.Controls.Add(this.cboChildren);
            this.Controls.Add(this.cboWomen);
            this.Controls.Add(this.cboMen);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWomen;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblMen;
        private System.Windows.Forms.ComboBox cboChildren;
        private System.Windows.Forms.ComboBox cboWomen;
        private System.Windows.Forms.ComboBox cboMen;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}