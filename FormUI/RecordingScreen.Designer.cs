namespace FormUI
{
    partial class RecordingScreen
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
            this.tbxEmailRC = new System.Windows.Forms.TextBox();
            this.lblEMail = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbxSurnameRC = new System.Windows.Forms.TextBox();
            this.tbxUserNameRC = new System.Windows.Forms.TextBox();
            this.tbxConfirmPasswordRC = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumberRC = new System.Windows.Forms.TextBox();
            this.tbxNameRC = new System.Windows.Forms.TextBox();
            this.tbxPasswordRC = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblGSM = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxEmailRC
            // 
            this.tbxEmailRC.AccessibleName = "txtEmail";
            this.tbxEmailRC.BackColor = System.Drawing.SystemColors.Info;
            this.tbxEmailRC.Location = new System.Drawing.Point(301, 109);
            this.tbxEmailRC.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmailRC.MaxLength = 30;
            this.tbxEmailRC.Name = "tbxEmailRC";
            this.tbxEmailRC.Size = new System.Drawing.Size(173, 22);
            this.tbxEmailRC.TabIndex = 69;
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.BackColor = System.Drawing.SystemColors.Control;
            this.lblEMail.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEMail.Location = new System.Drawing.Point(51, 101);
            this.lblEMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(214, 32);
            this.lblEMail.TabIndex = 83;
            this.lblEMail.Text = "E-Posta Adresi  :";
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.BackColor = System.Drawing.SystemColors.Info;
            this.chkShowPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkShowPassword.Location = new System.Drawing.Point(501, 168);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(137, 23);
            this.chkShowPassword.TabIndex = 82;
            this.chkShowPassword.Text = "Şifreyi Göster";
            this.chkShowPassword.UseVisualStyleBackColor = false;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.ForeColor = System.Drawing.Color.Red;
            this.btnRegister.Location = new System.Drawing.Point(301, 429);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(175, 79);
            this.btnRegister.TabIndex = 81;
            this.btnRegister.Text = "Kaydol";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(53, 213);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(225, 31);
            this.lblConfirmPassword.TabIndex = 80;
            this.lblConfirmPassword.Text = "Şifre Doğrulama :";
            // 
            // tbxSurnameRC
            // 
            this.tbxSurnameRC.AccessibleName = "txtSurname";
            this.tbxSurnameRC.BackColor = System.Drawing.SystemColors.Info;
            this.tbxSurnameRC.Location = new System.Drawing.Point(301, 377);
            this.tbxSurnameRC.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSurnameRC.Name = "tbxSurnameRC";
            this.tbxSurnameRC.Size = new System.Drawing.Size(173, 22);
            this.tbxSurnameRC.TabIndex = 74;
            this.tbxSurnameRC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSurnameRC_KeyPress);
            // 
            // tbxUserNameRC
            // 
            this.tbxUserNameRC.AccessibleName = "tbxUserName";
            this.tbxUserNameRC.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUserNameRC.Location = new System.Drawing.Point(301, 52);
            this.tbxUserNameRC.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUserNameRC.Name = "tbxUserNameRC";
            this.tbxUserNameRC.Size = new System.Drawing.Size(173, 22);
            this.tbxUserNameRC.TabIndex = 68;
            this.tbxUserNameRC.TextChanged += new System.EventHandler(this.tbxUserNameRC_TextChanged);
            this.tbxUserNameRC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUserNameRC_KeyPress);
            // 
            // tbxConfirmPasswordRC
            // 
            this.tbxConfirmPasswordRC.AccessibleName = "txtConfirmPassword";
            this.tbxConfirmPasswordRC.BackColor = System.Drawing.SystemColors.Info;
            this.tbxConfirmPasswordRC.Location = new System.Drawing.Point(301, 218);
            this.tbxConfirmPasswordRC.Margin = new System.Windows.Forms.Padding(4);
            this.tbxConfirmPasswordRC.Name = "tbxConfirmPasswordRC";
            this.tbxConfirmPasswordRC.Size = new System.Drawing.Size(173, 22);
            this.tbxConfirmPasswordRC.TabIndex = 71;
            this.tbxConfirmPasswordRC.UseSystemPasswordChar = true;
            // 
            // tbxPhoneNumberRC
            // 
            this.tbxPhoneNumberRC.AccessibleName = "txtPhoneNumber";
            this.tbxPhoneNumberRC.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPhoneNumberRC.Location = new System.Drawing.Point(301, 268);
            this.tbxPhoneNumberRC.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPhoneNumberRC.MaxLength = 10;
            this.tbxPhoneNumberRC.Name = "tbxPhoneNumberRC";
            this.tbxPhoneNumberRC.Size = new System.Drawing.Size(173, 22);
            this.tbxPhoneNumberRC.TabIndex = 72;
            this.tbxPhoneNumberRC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhoneNumberRC_KeyPress);
            // 
            // tbxNameRC
            // 
            this.tbxNameRC.AccessibleName = "txtName";
            this.tbxNameRC.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameRC.Location = new System.Drawing.Point(301, 322);
            this.tbxNameRC.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNameRC.Name = "tbxNameRC";
            this.tbxNameRC.Size = new System.Drawing.Size(173, 22);
            this.tbxNameRC.TabIndex = 73;
            this.tbxNameRC.TextChanged += new System.EventHandler(this.tbxNameRC_TextChanged);
            this.tbxNameRC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNameRC_KeyPress);
            // 
            // tbxPasswordRC
            // 
            this.tbxPasswordRC.AccessibleName = "txtPassword";
            this.tbxPasswordRC.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPasswordRC.Location = new System.Drawing.Point(301, 168);
            this.tbxPasswordRC.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPasswordRC.Name = "tbxPasswordRC";
            this.tbxPasswordRC.Size = new System.Drawing.Size(173, 22);
            this.tbxPasswordRC.TabIndex = 70;
            this.tbxPasswordRC.UseSystemPasswordChar = true;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(51, 367);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(104, 32);
            this.lblSurname.TabIndex = 79;
            this.lblSurname.Text = "Soyad :";
            // 
            // lblGSM
            // 
            this.lblGSM.AutoSize = true;
            this.lblGSM.BackColor = System.Drawing.SystemColors.Control;
            this.lblGSM.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGSM.Location = new System.Drawing.Point(51, 260);
            this.lblGSM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGSM.Name = "lblGSM";
            this.lblGSM.Size = new System.Drawing.Size(116, 32);
            this.lblGSM.TabIndex = 78;
            this.lblGSM.Text = "Telefon :";
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(51, 46);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 32);
            this.txtUserName.TabIndex = 77;
            this.txtUserName.Text = "Kullanıcı Adı :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(51, 158);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 32);
            this.lblPassword.TabIndex = 76;
            this.lblPassword.Text = "Şifre :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(51, 312);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 32);
            this.lblName.TabIndex = 75;
            this.lblName.Text = "Ad :";
            // 
            // RecordingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 591);
            this.Controls.Add(this.tbxEmailRC);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.tbxSurnameRC);
            this.Controls.Add(this.tbxUserNameRC);
            this.Controls.Add(this.tbxConfirmPasswordRC);
            this.Controls.Add(this.tbxPhoneNumberRC);
            this.Controls.Add(this.tbxNameRC);
            this.Controls.Add(this.tbxPasswordRC);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblGSM);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Name = "RecordingScreen";
            this.Text = "RecordingScreen";
            this.Load += new System.EventHandler(this.RecordingScreen_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RecordingScreen_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEmailRC;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tbxSurnameRC;
        private System.Windows.Forms.TextBox tbxUserNameRC;
        private System.Windows.Forms.TextBox tbxConfirmPasswordRC;
        private System.Windows.Forms.TextBox tbxPhoneNumberRC;
        private System.Windows.Forms.TextBox tbxNameRC;
        private System.Windows.Forms.TextBox tbxPasswordRC;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblGSM;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
    }
}