namespace ShirtShop
{
    partial class frmMain
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.llblLogIn = new System.Windows.Forms.LinkLabel();
            this.llblRegisterNewUser = new System.Windows.Forms.LinkLabel();
            this.llblShoppingCart = new System.Windows.Forms.LinkLabel();
            this.llblCachRegister = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(1558, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sök";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1628, 147);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 38);
            this.textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(788, 223);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(900, 531);
            this.listBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hattar",
            "T-shirts",
            "Skor"});
            this.comboBox1.Location = new System.Drawing.Point(22, 81);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 39);
            this.comboBox1.TabIndex = 7;
            // 
            // llblLogIn
            // 
            this.llblLogIn.AutoSize = true;
            this.llblLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llblLogIn.LinkColor = System.Drawing.Color.Black;
            this.llblLogIn.Location = new System.Drawing.Point(1420, 43);
            this.llblLogIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblLogIn.Name = "llblLogIn";
            this.llblLogIn.Size = new System.Drawing.Size(125, 32);
            this.llblLogIn.TabIndex = 9;
            this.llblLogIn.TabStop = true;
            this.llblLogIn.Text = "Logga in";
            this.llblLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLogIn_LinkClicked);
            // 
            // llblRegisterNewUser
            // 
            this.llblRegisterNewUser.AutoSize = true;
            this.llblRegisterNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llblRegisterNewUser.LinkColor = System.Drawing.Color.Black;
            this.llblRegisterNewUser.Location = new System.Drawing.Point(1568, 43);
            this.llblRegisterNewUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblRegisterNewUser.Name = "llblRegisterNewUser";
            this.llblRegisterNewUser.Size = new System.Drawing.Size(146, 32);
            this.llblRegisterNewUser.TabIndex = 10;
            this.llblRegisterNewUser.TabStop = true;
            this.llblRegisterNewUser.Text = "Registrera";
            this.llblRegisterNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegisterNewUser_LinkClicked);
            // 
            // llblShoppingCart
            // 
            this.llblShoppingCart.AutoSize = true;
            this.llblShoppingCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llblShoppingCart.LinkColor = System.Drawing.Color.Black;
            this.llblShoppingCart.Location = new System.Drawing.Point(1744, 43);
            this.llblShoppingCart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblShoppingCart.Name = "llblShoppingCart";
            this.llblShoppingCart.Size = new System.Drawing.Size(130, 32);
            this.llblShoppingCart.TabIndex = 11;
            this.llblShoppingCart.TabStop = true;
            this.llblShoppingCart.Text = "Varukorg";
            this.llblShoppingCart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShoppingCart_LinkClicked);
            // 
            // llblCachRegister
            // 
            this.llblCachRegister.AutoSize = true;
            this.llblCachRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llblCachRegister.LinkColor = System.Drawing.Color.Black;
            this.llblCachRegister.Location = new System.Drawing.Point(1916, 43);
            this.llblCachRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblCachRegister.Name = "llblCachRegister";
            this.llblCachRegister.Size = new System.Drawing.Size(94, 32);
            this.llblCachRegister.TabIndex = 12;
            this.llblCachRegister.TabStop = true;
            this.llblCachRegister.Text = "Kassa";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(1936, 223);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 32);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hitta";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Hattar",
            "T-shirts",
            "Skor"});
            this.comboBox2.Location = new System.Drawing.Point(278, 81);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 39);
            this.comboBox2.TabIndex = 15;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Hattar",
            "T-shirts",
            "Skor"});
            this.comboBox3.Location = new System.Drawing.Point(528, 81);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(216, 39);
            this.comboBox3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Herr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(522, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Barn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(272, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dam";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(2040, 967);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.llblCachRegister);
            this.Controls.Add(this.llblShoppingCart);
            this.Controls.Add(this.llblRegisterNewUser);
            this.Controls.Add(this.llblLogIn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmMain";
            this.Text = "ShirtShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel llblLogIn;
        private System.Windows.Forms.LinkLabel llblRegisterNewUser;
        private System.Windows.Forms.LinkLabel llblShoppingCart;
        private System.Windows.Forms.LinkLabel llblCachRegister;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

