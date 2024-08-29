namespace FormUI
{
    partial class Form1
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
            this.gbxPrice = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tbxDay = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblKMText = new System.Windows.Forms.Label();
            this.lblKMData = new System.Windows.Forms.Label();
            this.lblYearText = new System.Windows.Forms.Label();
            this.lblColorText = new System.Windows.Forms.Label();
            this.lblUnitPriceText = new System.Windows.Forms.Label();
            this.lblModelText = new System.Windows.Forms.Label();
            this.lblBrandText = new System.Windows.Forms.Label();
            this.lblYearData = new System.Windows.Forms.Label();
            this.lnlColorData = new System.Windows.Forms.Label();
            this.btnMyFavorites = new System.Windows.Forms.Button();
            this.btnAddFavorites = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lblUnitPriceData = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblModelData = new System.Windows.Forms.Label();
            this.lblBrandData = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.gbxData = new System.Windows.Forms.GroupBox();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxPrice.SuspendLayout();
            this.gbxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPrice
            // 
            this.gbxPrice.Controls.Add(this.lblPrice);
            this.gbxPrice.Controls.Add(this.lblTotalPrice);
            this.gbxPrice.Controls.Add(this.tbxDay);
            this.gbxPrice.Controls.Add(this.lblDay);
            this.gbxPrice.Location = new System.Drawing.Point(880, 373);
            this.gbxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxPrice.Name = "gbxPrice";
            this.gbxPrice.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxPrice.Size = new System.Drawing.Size(429, 190);
            this.gbxPrice.TabIndex = 19;
            this.gbxPrice.TabStop = false;
            this.gbxPrice.Text = "Hesap";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(145, 94);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 16);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "________";
            this.lblPrice.UseWaitCursor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(8, 94);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(92, 16);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "Toplam Fiyat :";
            this.lblTotalPrice.UseWaitCursor = true;
            // 
            // tbxDay
            // 
            this.tbxDay.Location = new System.Drawing.Point(212, 43);
            this.tbxDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDay.MaxLength = 2;
            this.tbxDay.Name = "tbxDay";
            this.tbxDay.Size = new System.Drawing.Size(132, 22);
            this.tbxDay.TabIndex = 8;
            this.tbxDay.TextChanged += new System.EventHandler(this.tbxDay_TextChanged);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(8, 43);
            this.lblDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(147, 16);
            this.lblDay.TabIndex = 7;
            this.lblDay.Text = "Kiralanacak gün sayısı :";
            // 
            // lblKMText
            // 
            this.lblKMText.AutoSize = true;
            this.lblKMText.Location = new System.Drawing.Point(583, 190);
            this.lblKMText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKMText.Name = "lblKMText";
            this.lblKMText.Size = new System.Drawing.Size(77, 16);
            this.lblKMText.TabIndex = 12;
            this.lblKMText.Text = "__________";
            this.lblKMText.UseWaitCursor = true;
            // 
            // lblKMData
            // 
            this.lblKMData.AutoSize = true;
            this.lblKMData.Location = new System.Drawing.Point(485, 190);
            this.lblKMData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKMData.Name = "lblKMData";
            this.lblKMData.Size = new System.Drawing.Size(32, 16);
            this.lblKMData.TabIndex = 11;
            this.lblKMData.Text = "KM :";
            this.lblKMData.UseWaitCursor = true;
            // 
            // lblYearText
            // 
            this.lblYearText.AutoSize = true;
            this.lblYearText.Location = new System.Drawing.Point(583, 133);
            this.lblYearText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYearText.Name = "lblYearText";
            this.lblYearText.Size = new System.Drawing.Size(77, 16);
            this.lblYearText.TabIndex = 10;
            this.lblYearText.Text = "__________";
            this.lblYearText.UseWaitCursor = true;
            // 
            // lblColorText
            // 
            this.lblColorText.AutoSize = true;
            this.lblColorText.Location = new System.Drawing.Point(583, 79);
            this.lblColorText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblColorText.Name = "lblColorText";
            this.lblColorText.Size = new System.Drawing.Size(77, 16);
            this.lblColorText.TabIndex = 9;
            this.lblColorText.Text = "__________";
            this.lblColorText.UseWaitCursor = true;
            // 
            // lblUnitPriceText
            // 
            this.lblUnitPriceText.AutoSize = true;
            this.lblUnitPriceText.Location = new System.Drawing.Point(185, 190);
            this.lblUnitPriceText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUnitPriceText.Name = "lblUnitPriceText";
            this.lblUnitPriceText.Size = new System.Drawing.Size(77, 16);
            this.lblUnitPriceText.TabIndex = 8;
            this.lblUnitPriceText.Text = "__________";
            this.lblUnitPriceText.UseWaitCursor = true;
            // 
            // lblModelText
            // 
            this.lblModelText.AutoSize = true;
            this.lblModelText.Location = new System.Drawing.Point(185, 133);
            this.lblModelText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblModelText.Name = "lblModelText";
            this.lblModelText.Size = new System.Drawing.Size(77, 16);
            this.lblModelText.TabIndex = 7;
            this.lblModelText.Text = "__________";
            this.lblModelText.UseWaitCursor = true;
            // 
            // lblBrandText
            // 
            this.lblBrandText.AutoSize = true;
            this.lblBrandText.Location = new System.Drawing.Point(185, 79);
            this.lblBrandText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBrandText.Name = "lblBrandText";
            this.lblBrandText.Size = new System.Drawing.Size(77, 16);
            this.lblBrandText.TabIndex = 6;
            this.lblBrandText.Text = "__________";
            this.lblBrandText.UseWaitCursor = true;
            // 
            // lblYearData
            // 
            this.lblYearData.AutoSize = true;
            this.lblYearData.Location = new System.Drawing.Point(485, 133);
            this.lblYearData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYearData.Name = "lblYearData";
            this.lblYearData.Size = new System.Drawing.Size(28, 16);
            this.lblYearData.TabIndex = 5;
            this.lblYearData.Text = "Yıl :";
            this.lblYearData.UseWaitCursor = true;
            // 
            // lnlColorData
            // 
            this.lnlColorData.AutoSize = true;
            this.lnlColorData.Location = new System.Drawing.Point(481, 79);
            this.lnlColorData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnlColorData.Name = "lnlColorData";
            this.lnlColorData.Size = new System.Drawing.Size(45, 16);
            this.lnlColorData.TabIndex = 3;
            this.lnlColorData.Text = "Renk :";
            this.lnlColorData.UseWaitCursor = true;
            // 
            // btnMyFavorites
            // 
            this.btnMyFavorites.Location = new System.Drawing.Point(1156, 220);
            this.btnMyFavorites.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMyFavorites.Name = "btnMyFavorites";
            this.btnMyFavorites.Size = new System.Drawing.Size(155, 62);
            this.btnMyFavorites.TabIndex = 18;
            this.btnMyFavorites.Text = "Favorilerim";
            this.btnMyFavorites.UseVisualStyleBackColor = true;
            this.btnMyFavorites.Click += new System.EventHandler(this.btnMyFavorites_Click);
            // 
            // btnAddFavorites
            // 
            this.btnAddFavorites.Location = new System.Drawing.Point(1156, 82);
            this.btnAddFavorites.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAddFavorites.Name = "btnAddFavorites";
            this.btnAddFavorites.Size = new System.Drawing.Size(155, 53);
            this.btnAddFavorites.TabIndex = 17;
            this.btnAddFavorites.Text = "Favorilerime Ekle";
            this.btnAddFavorites.UseVisualStyleBackColor = true;
            this.btnAddFavorites.Click += new System.EventHandler(this.btnAddFavorites_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(1156, 144);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(155, 66);
            this.btnHistory.TabIndex = 16;
            this.btnHistory.Text = "Geçmiş";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lblUnitPriceData
            // 
            this.lblUnitPriceData.AutoSize = true;
            this.lblUnitPriceData.Location = new System.Drawing.Point(69, 190);
            this.lblUnitPriceData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUnitPriceData.Name = "lblUnitPriceData";
            this.lblUnitPriceData.Size = new System.Drawing.Size(42, 16);
            this.lblUnitPriceData.TabIndex = 2;
            this.lblUnitPriceData.Text = "Fiyat :";
            this.lblUnitPriceData.UseWaitCursor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(1156, 16);
            this.btnShow.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(155, 58);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Göster";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblModelData
            // 
            this.lblModelData.AutoSize = true;
            this.lblModelData.Location = new System.Drawing.Point(69, 133);
            this.lblModelData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblModelData.Name = "lblModelData";
            this.lblModelData.Size = new System.Drawing.Size(51, 16);
            this.lblModelData.TabIndex = 1;
            this.lblModelData.Text = "Model :";
            this.lblModelData.UseWaitCursor = true;
            // 
            // lblBrandData
            // 
            this.lblBrandData.AutoSize = true;
            this.lblBrandData.Location = new System.Drawing.Point(69, 79);
            this.lblBrandData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBrandData.Name = "lblBrandData";
            this.lblBrandData.Size = new System.Drawing.Size(51, 16);
            this.lblBrandData.TabIndex = 0;
            this.lblBrandData.Text = "Marka :";
            this.lblBrandData.UseWaitCursor = true;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(1155, 619);
            this.btnRent.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(155, 73);
            this.btnRent.TabIndex = 15;
            this.btnRent.Text = "Kirala";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // gbxData
            // 
            this.gbxData.Controls.Add(this.lblKMText);
            this.gbxData.Controls.Add(this.lblKMData);
            this.gbxData.Controls.Add(this.lblYearText);
            this.gbxData.Controls.Add(this.lblColorText);
            this.gbxData.Controls.Add(this.lblUnitPriceText);
            this.gbxData.Controls.Add(this.lblModelText);
            this.gbxData.Controls.Add(this.lblBrandText);
            this.gbxData.Controls.Add(this.lblYearData);
            this.gbxData.Controls.Add(this.lnlColorData);
            this.gbxData.Controls.Add(this.lblUnitPriceData);
            this.gbxData.Controls.Add(this.lblModelData);
            this.gbxData.Controls.Add(this.lblBrandData);
            this.gbxData.Location = new System.Drawing.Point(17, 373);
            this.gbxData.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxData.Name = "gbxData";
            this.gbxData.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxData.Size = new System.Drawing.Size(833, 340);
            this.gbxData.TabIndex = 13;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "Bilgiler";
            // 
            // dgwProduct
            // 
            this.dgwProduct.AllowUserToAddRows = false;
            this.dgwProduct.AllowUserToDeleteRows = false;
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(17, 16);
            this.dgwProduct.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgwProduct.MultiSelect = false;
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.ReadOnly = true;
            this.dgwProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProduct.Size = new System.Drawing.Size(1129, 348);
            this.dgwProduct.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 737);
            this.Controls.Add(this.gbxPrice);
            this.Controls.Add(this.btnMyFavorites);
            this.Controls.Add(this.btnAddFavorites);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.gbxData);
            this.Controls.Add(this.dgwProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxPrice.ResumeLayout(false);
            this.gbxPrice.PerformLayout();
            this.gbxData.ResumeLayout(false);
            this.gbxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox tbxDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblKMText;
        private System.Windows.Forms.Label lblKMData;
        private System.Windows.Forms.Label lblYearText;
        private System.Windows.Forms.Label lblColorText;
        private System.Windows.Forms.Label lblUnitPriceText;
        private System.Windows.Forms.Label lblModelText;
        private System.Windows.Forms.Label lblBrandText;
        private System.Windows.Forms.Label lblYearData;
        private System.Windows.Forms.Label lnlColorData;
        private System.Windows.Forms.Button btnMyFavorites;
        private System.Windows.Forms.Button btnAddFavorites;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label lblUnitPriceData;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblModelData;
        private System.Windows.Forms.Label lblBrandData;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.GroupBox gbxData;
        private System.Windows.Forms.DataGridView dgwProduct;
    }
}

