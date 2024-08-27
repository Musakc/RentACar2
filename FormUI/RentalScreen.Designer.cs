namespace FormUI
{
    partial class RentalScreen
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
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.tbxAddressSales = new System.Windows.Forms.TextBox();
            this.tbxCardNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxTCSales = new System.Windows.Forms.TextBox();
            this.tbxGSMSales = new System.Windows.Forms.TextBox();
            this.tbxMailSales = new System.Windows.Forms.TextBox();
            this.tbxSurnameSales = new System.Windows.Forms.TextBox();
            this.tbxNameSales = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbxCardInfo = new System.Windows.Forms.GroupBox();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbxCarIdSales = new System.Windows.Forms.TextBox();
            this.lblAddressSales = new System.Windows.Forms.Label();
            this.lblTCSales = new System.Windows.Forms.Label();
            this.cbxConfirm = new System.Windows.Forms.CheckBox();
            this.lblGSMSales = new System.Windows.Forms.Label();
            this.lblWarningCardNumber = new System.Windows.Forms.Label();
            this.lblMailSales = new System.Windows.Forms.Label();
            this.lblSurnameSales = new System.Windows.Forms.Label();
            this.lblNameSales = new System.Windows.Forms.Label();
            this.lblCarIdSales = new System.Windows.Forms.Label();
            this.gbxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbxCardInfo.SuspendLayout();
            this.gbxCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(53, 47);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(73, 13);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Kart Numarası";
            // 
            // tbxAddressSales
            // 
            this.tbxAddressSales.Location = new System.Drawing.Point(40, 316);
            this.tbxAddressSales.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddressSales.Multiline = true;
            this.tbxAddressSales.Name = "tbxAddressSales";
            this.tbxAddressSales.Size = new System.Drawing.Size(319, 96);
            this.tbxAddressSales.TabIndex = 13;
            // 
            // tbxCardNumber
            // 
            this.tbxCardNumber.Location = new System.Drawing.Point(55, 99);
            this.tbxCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCardNumber.MaxLength = 16;
            this.tbxCardNumber.Name = "tbxCardNumber";
            this.tbxCardNumber.Size = new System.Drawing.Size(341, 20);
            this.tbxCardNumber.TabIndex = 8;
            this.tbxCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCardNumber_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(323, 423);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbxTCSales
            // 
            this.tbxTCSales.Location = new System.Drawing.Point(103, 249);
            this.tbxTCSales.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTCSales.Name = "tbxTCSales";
            this.tbxTCSales.Size = new System.Drawing.Size(256, 20);
            this.tbxTCSales.TabIndex = 12;
            this.tbxTCSales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTCSales_KeyPress);
            // 
            // tbxGSMSales
            // 
            this.tbxGSMSales.Location = new System.Drawing.Point(93, 208);
            this.tbxGSMSales.Margin = new System.Windows.Forms.Padding(4);
            this.tbxGSMSales.Name = "tbxGSMSales";
            this.tbxGSMSales.Size = new System.Drawing.Size(265, 20);
            this.tbxGSMSales.TabIndex = 11;
            this.tbxGSMSales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGSMSales_KeyPress);
            // 
            // tbxMailSales
            // 
            this.tbxMailSales.Location = new System.Drawing.Point(129, 159);
            this.tbxMailSales.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMailSales.Name = "tbxMailSales";
            this.tbxMailSales.Size = new System.Drawing.Size(229, 20);
            this.tbxMailSales.TabIndex = 10;
            // 
            // tbxSurnameSales
            // 
            this.tbxSurnameSales.Location = new System.Drawing.Point(108, 123);
            this.tbxSurnameSales.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSurnameSales.Name = "tbxSurnameSales";
            this.tbxSurnameSales.Size = new System.Drawing.Size(251, 20);
            this.tbxSurnameSales.TabIndex = 9;
            // 
            // tbxNameSales
            // 
            this.tbxNameSales.Location = new System.Drawing.Point(85, 82);
            this.tbxNameSales.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNameSales.Name = "tbxNameSales";
            this.tbxNameSales.Size = new System.Drawing.Size(273, 20);
            this.tbxNameSales.TabIndex = 8;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(610, 447);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(307, 66);
            this.btnConfirm.TabIndex = 23;
            this.btnConfirm.Text = "ÖDEMEYİ TAMAMLA";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // gbxCardInfo
            // 
            this.gbxCardInfo.Controls.Add(this.cbxYear);
            this.gbxCardInfo.Controls.Add(this.tbxPassword);
            this.gbxCardInfo.Controls.Add(this.cbxMonth);
            this.gbxCardInfo.Controls.Add(this.tbxCardNumber);
            this.gbxCardInfo.Controls.Add(this.lblPassword);
            this.gbxCardInfo.Controls.Add(this.lblDate);
            this.gbxCardInfo.Controls.Add(this.lblCardNumber);
            this.gbxCardInfo.Location = new System.Drawing.Point(490, 15);
            this.gbxCardInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCardInfo.Name = "gbxCardInfo";
            this.gbxCardInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCardInfo.Size = new System.Drawing.Size(493, 228);
            this.gbxCardInfo.TabIndex = 22;
            this.gbxCardInfo.TabStop = false;
            this.gbxCardInfo.Text = "Kart Bilgileri";
            // 
            // cbxYear
            // 
            this.cbxYear.BackColor = System.Drawing.SystemColors.Window;
            this.cbxYear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044"});
            this.cbxYear.Location = new System.Drawing.Point(131, 166);
            this.cbxYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbxYear.MaxDropDownItems = 4;
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(67, 21);
            this.cbxYear.TabIndex = 4;
            this.cbxYear.Text = "Yıl";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(264, 167);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.MaxLength = 3;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(132, 20);
            this.tbxPassword.TabIndex = 10;
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_KeyPress);
            // 
            // cbxMonth
            // 
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbxMonth.Location = new System.Drawing.Point(55, 167);
            this.cbxMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMonth.MaxDropDownItems = 4;
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(67, 21);
            this.cbxMonth.TabIndex = 3;
            this.cbxMonth.Text = "Ay";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(273, 140);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(28, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "CVV";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(53, 135);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(101, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Son Kullanma Tarihi";
            // 
            // tbxCarIdSales
            // 
            this.tbxCarIdSales.Location = new System.Drawing.Point(200, 41);
            this.tbxCarIdSales.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCarIdSales.Name = "tbxCarIdSales";
            this.tbxCarIdSales.Size = new System.Drawing.Size(159, 20);
            this.tbxCarIdSales.TabIndex = 7;
            // 
            // lblAddressSales
            // 
            this.lblAddressSales.AutoSize = true;
            this.lblAddressSales.Location = new System.Drawing.Point(36, 297);
            this.lblAddressSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressSales.Name = "lblAddressSales";
            this.lblAddressSales.Size = new System.Drawing.Size(84, 13);
            this.lblAddressSales.TabIndex = 6;
            this.lblAddressSales.Text = "Teslimat Adresi :";
            // 
            // lblTCSales
            // 
            this.lblTCSales.AutoSize = true;
            this.lblTCSales.Location = new System.Drawing.Point(36, 252);
            this.lblTCSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTCSales.Name = "lblTCSales";
            this.lblTCSales.Size = new System.Drawing.Size(44, 13);
            this.lblTCSales.TabIndex = 5;
            this.lblTCSales.Text = "TC No :";
            // 
            // cbxConfirm
            // 
            this.cbxConfirm.AutoSize = true;
            this.cbxConfirm.Location = new System.Drawing.Point(480, 267);
            this.cbxConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.cbxConfirm.Name = "cbxConfirm";
            this.cbxConfirm.Size = new System.Drawing.Size(406, 17);
            this.cbxConfirm.TabIndex = 24;
            this.cbxConfirm.Text = "Ön Bilgilendirme Koşulları\'nı ve Mesafeli Satış Sözleşmesi\'ni okudum, onaylıyorum" +
    ".";
            this.cbxConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxConfirm.UseVisualStyleBackColor = true;
            // 
            // lblGSMSales
            // 
            this.lblGSMSales.AutoSize = true;
            this.lblGSMSales.Location = new System.Drawing.Point(36, 212);
            this.lblGSMSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGSMSales.Name = "lblGSMSales";
            this.lblGSMSales.Size = new System.Drawing.Size(37, 13);
            this.lblGSMSales.TabIndex = 4;
            this.lblGSMSales.Text = "GSM :";
            // 
            // lblWarningCardNumber
            // 
            this.lblWarningCardNumber.AutoSize = true;
            this.lblWarningCardNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWarningCardNumber.Location = new System.Drawing.Point(619, 409);
            this.lblWarningCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarningCardNumber.Name = "lblWarningCardNumber";
            this.lblWarningCardNumber.Size = new System.Drawing.Size(0, 13);
            this.lblWarningCardNumber.TabIndex = 20;
            // 
            // lblMailSales
            // 
            this.lblMailSales.AutoSize = true;
            this.lblMailSales.Location = new System.Drawing.Point(36, 167);
            this.lblMailSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMailSales.Name = "lblMailSales";
            this.lblMailSales.Size = new System.Drawing.Size(64, 13);
            this.lblMailSales.TabIndex = 3;
            this.lblMailSales.Text = "Mail Adresi :";
            // 
            // lblSurnameSales
            // 
            this.lblSurnameSales.AutoSize = true;
            this.lblSurnameSales.Location = new System.Drawing.Point(36, 127);
            this.lblSurnameSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurnameSales.Name = "lblSurnameSales";
            this.lblSurnameSales.Size = new System.Drawing.Size(48, 13);
            this.lblSurnameSales.TabIndex = 2;
            this.lblSurnameSales.Text = "Soyisim :";
            // 
            // lblNameSales
            // 
            this.lblNameSales.AutoSize = true;
            this.lblNameSales.Location = new System.Drawing.Point(36, 86);
            this.lblNameSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameSales.Name = "lblNameSales";
            this.lblNameSales.Size = new System.Drawing.Size(31, 13);
            this.lblNameSales.TabIndex = 1;
            this.lblNameSales.Text = "İsim :";
            // 
            // lblCarIdSales
            // 
            this.lblCarIdSales.AutoSize = true;
            this.lblCarIdSales.Location = new System.Drawing.Point(36, 44);
            this.lblCarIdSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarIdSales.Name = "lblCarIdSales";
            this.lblCarIdSales.Size = new System.Drawing.Size(117, 13);
            this.lblCarIdSales.TabIndex = 0;
            this.lblCarIdSales.Text = "Kiralanacak Araba No :";
            // 
            // gbxCustomerInfo
            // 
            this.gbxCustomerInfo.Controls.Add(this.btnSave);
            this.gbxCustomerInfo.Controls.Add(this.tbxAddressSales);
            this.gbxCustomerInfo.Controls.Add(this.tbxTCSales);
            this.gbxCustomerInfo.Controls.Add(this.tbxGSMSales);
            this.gbxCustomerInfo.Controls.Add(this.tbxMailSales);
            this.gbxCustomerInfo.Controls.Add(this.tbxSurnameSales);
            this.gbxCustomerInfo.Controls.Add(this.tbxNameSales);
            this.gbxCustomerInfo.Controls.Add(this.tbxCarIdSales);
            this.gbxCustomerInfo.Controls.Add(this.lblAddressSales);
            this.gbxCustomerInfo.Controls.Add(this.lblTCSales);
            this.gbxCustomerInfo.Controls.Add(this.lblGSMSales);
            this.gbxCustomerInfo.Controls.Add(this.lblMailSales);
            this.gbxCustomerInfo.Controls.Add(this.lblSurnameSales);
            this.gbxCustomerInfo.Controls.Add(this.lblNameSales);
            this.gbxCustomerInfo.Controls.Add(this.lblCarIdSales);
            this.gbxCustomerInfo.Enabled = false;
            this.gbxCustomerInfo.Location = new System.Drawing.Point(13, 13);
            this.gbxCustomerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCustomerInfo.Name = "gbxCustomerInfo";
            this.gbxCustomerInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCustomerInfo.Size = new System.Drawing.Size(435, 464);
            this.gbxCustomerInfo.TabIndex = 21;
            this.gbxCustomerInfo.TabStop = false;
            this.gbxCustomerInfo.Text = "Alıcı Bilgileri";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(330, 484);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 31);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "düzenle";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // RentalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 532);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbxCardInfo);
            this.Controls.Add(this.cbxConfirm);
            this.Controls.Add(this.lblWarningCardNumber);
            this.Controls.Add(this.gbxCustomerInfo);
            this.Controls.Add(this.btnEdit);
            this.Name = "RentalScreen";
            this.Text = "RentalScreen";
            this.gbxCardInfo.ResumeLayout(false);
            this.gbxCardInfo.PerformLayout();
            this.gbxCustomerInfo.ResumeLayout(false);
            this.gbxCustomerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox tbxAddressSales;
        private System.Windows.Forms.TextBox tbxCardNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxTCSales;
        private System.Windows.Forms.TextBox tbxGSMSales;
        private System.Windows.Forms.TextBox tbxMailSales;
        private System.Windows.Forms.TextBox tbxSurnameSales;
        private System.Windows.Forms.TextBox tbxNameSales;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox gbxCardInfo;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbxCarIdSales;
        private System.Windows.Forms.Label lblAddressSales;
        private System.Windows.Forms.Label lblTCSales;
        private System.Windows.Forms.CheckBox cbxConfirm;
        private System.Windows.Forms.Label lblGSMSales;
        private System.Windows.Forms.Label lblWarningCardNumber;
        private System.Windows.Forms.Label lblMailSales;
        private System.Windows.Forms.Label lblSurnameSales;
        private System.Windows.Forms.Label lblNameSales;
        private System.Windows.Forms.Label lblCarIdSales;
        private System.Windows.Forms.GroupBox gbxCustomerInfo;
        private System.Windows.Forms.Button btnEdit;
    }
}