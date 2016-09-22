namespace ShirtShop
{
    partial class frmRegister
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAlreadyAMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(186, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(343, 23);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 61);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 17);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Förnamn";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 107);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 17);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Efternamn";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 184);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 17);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Adress";
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(12, 264);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(56, 17);
            this.lblMobileNumber.TabIndex = 5;
            this.lblMobileNumber.Text = "Telefon";
            this.lblMobileNumber.Click += new System.EventHandler(this.lblMobileNumber_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 383);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(104, 17);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Användarnamn";
            this.lblUsername.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(12, 222);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(37, 17);
            this.lblCityName.TabIndex = 7;
            this.lblCityName.Text = "Stad";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 438);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 17);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Lösenord";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.Location = new System.Drawing.Point(258, 336);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(207, 25);
            this.lblUserInfo.TabIndex = 9;
            this.lblUserInfo.Text = "Inloggningsuppgifter";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(186, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(343, 23);
            this.txtLastName.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(186, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(186, 178);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(343, 23);
            this.txtAdress.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(186, 216);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(343, 23);
            this.txtCity.TabIndex = 13;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(186, 258);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(343, 23);
            this.txtTelephone.TabIndex = 14;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(186, 377);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(343, 23);
            this.txtUsername.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(186, 432);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(343, 23);
            this.txtPassword.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kontaktuppgifter";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(186, 492);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(99, 42);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Registrera";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(308, 492);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 42);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Rensa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAlreadyAMember
            // 
            this.btnAlreadyAMember.Location = new System.Drawing.Point(430, 492);
            this.btnAlreadyAMember.Name = "btnAlreadyAMember";
            this.btnAlreadyAMember.Size = new System.Drawing.Size(99, 42);
            this.btnAlreadyAMember.TabIndex = 20;
            this.btnAlreadyAMember.Text = "Jag är redan medlem";
            this.btnAlreadyAMember.UseVisualStyleBackColor = true;
            this.btnAlreadyAMember.Click += new System.EventHandler(this.btnAlreadyAMember_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 546);
            this.Controls.Add(this.btnAlreadyAMember);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblMobileNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAlreadyAMember;
    }
}