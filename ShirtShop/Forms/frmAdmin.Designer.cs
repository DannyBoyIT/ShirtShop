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
            this.cmbKid = new System.Windows.Forms.ComboBox();
            this.cmbWomen = new System.Windows.Forms.ComboBox();
            this.cmbMen = new System.Windows.Forms.ComboBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnChangeProduct = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
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
            // cmbKid
            // 
            this.cmbKid.FormattingEnabled = true;
            this.cmbKid.Items.AddRange(new object[] {
            "Hattar",
            "T-shirts",
            "Skor"});
            this.cmbKid.Location = new System.Drawing.Point(264, 42);
            this.cmbKid.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKid.Name = "cmbKid";
            this.cmbKid.Size = new System.Drawing.Size(110, 24);
            this.cmbKid.TabIndex = 25;
            // 
            // cmbWomen
            // 
            this.cmbWomen.FormattingEnabled = true;
            this.cmbWomen.Items.AddRange(new object[] {
            "Hattar",
            "T-shirts",
            "Skor"});
            this.cmbWomen.Location = new System.Drawing.Point(139, 42);
            this.cmbWomen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbWomen.Name = "cmbWomen";
            this.cmbWomen.Size = new System.Drawing.Size(110, 24);
            this.cmbWomen.TabIndex = 24;
            // 
            // cmbMen
            // 
            this.cmbMen.FormattingEnabled = true;
            this.cmbMen.Items.AddRange(new object[] {
            "Hattar",
            "T-shirts",
            "Skor"});
            this.cmbMen.Location = new System.Drawing.Point(11, 42);
            this.cmbMen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMen.Name = "cmbMen";
            this.cmbMen.Size = new System.Drawing.Size(110, 24);
            this.cmbMen.TabIndex = 23;
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
            this.txtSearch.Location = new System.Drawing.Point(655, 79);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 22);
            this.txtSearch.TabIndex = 21;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSearch.Location = new System.Drawing.Point(620, 79);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(32, 17);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Sök";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 22);
            this.txtName.TabIndex = 29;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(139, 143);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 22);
            this.txtPrice.TabIndex = 29;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(394, 396);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveProduct.TabIndex = 30;
            this.btnRemoveProduct.Text = "Ta bort";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btnChangeProduct
            // 
            this.btnChangeProduct.Location = new System.Drawing.Point(139, 284);
            this.btnChangeProduct.Name = "btnChangeProduct";
            this.btnChangeProduct.Size = new System.Drawing.Size(160, 23);
            this.btnChangeProduct.TabIndex = 30;
            this.btnChangeProduct.Text = "Spara ändringar";
            this.btnChangeProduct.UseVisualStyleBackColor = true;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(139, 313);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(160, 23);
            this.btnCreateProduct.TabIndex = 30;
            this.btnCreateProduct.Text = "Lägg till produkt";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(86, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Namn";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(86, 146);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 17);
            this.lblPrice.TabIndex = 31;
            this.lblPrice.Text = "Pris";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(86, 202);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(32, 17);
            this.lblType.TabIndex = 31;
            this.lblType.Text = "Typ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(86, 230);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(33, 17);
            this.lblGender.TabIndex = 31;
            this.lblGender.Text = "Kön";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 22);
            this.textBox3.TabIndex = 29;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(86, 173);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(52, 17);
            this.lblSize.TabIndex = 31;
            this.lblSize.Text = "Storlek";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Dam",
            "Herr"});
            this.cmbGender.Location = new System.Drawing.Point(139, 227);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(160, 24);
            this.cmbGender.TabIndex = 32;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(139, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 21);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Barn";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "T-shirt",
            "Skor",
            "Hatt"});
            this.cmbType.Location = new System.Drawing.Point(139, 199);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(160, 24);
            this.cmbType.TabIndex = 32;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(900, 499);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.btnChangeProduct);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblWomen);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.lblMen);
            this.Controls.Add(this.cmbKid);
            this.Controls.Add(this.cmbWomen);
            this.Controls.Add(this.cmbMen);
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
        private System.Windows.Forms.ComboBox cmbKid;
        private System.Windows.Forms.ComboBox cmbWomen;
        private System.Windows.Forms.ComboBox cmbMen;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnChangeProduct;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbType;
    }
}