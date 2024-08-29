namespace FormUI
{
    partial class FavoritesScreen
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
            this.btnRent = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblKMText = new System.Windows.Forms.Label();
            this.lblKMData = new System.Windows.Forms.Label();
            this.lblYearText = new System.Windows.Forms.Label();
            this.lblColorText = new System.Windows.Forms.Label();
            this.lblUnitPriceText = new System.Windows.Forms.Label();
            this.lblModelText = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblBrandText = new System.Windows.Forms.Label();
            this.lblYearData = new System.Windows.Forms.Label();
            this.lnlColorData = new System.Windows.Forms.Label();
            this.lblUnitPriceData = new System.Windows.Forms.Label();
            this.lblModelData = new System.Windows.Forms.Label();
            this.lblBrandData = new System.Windows.Forms.Label();
            this.gbxData = new System.Windows.Forms.GroupBox();
            this.dgwMyFavorites = new System.Windows.Forms.DataGridView();
            this.gbxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMyFavorites)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(1156, 224);
            this.btnRent.Margin = new System.Windows.Forms.Padding(5);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(155, 73);
            this.btnRent.TabIndex = 21;
            this.btnRent.Text = "Kirala";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1156, 130);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 69);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Kaldır";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(1156, 31);
            this.btnShow.Margin = new System.Windows.Forms.Padding(5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(155, 74);
            this.btnShow.TabIndex = 18;
            this.btnShow.Text = "Göster";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
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
            // 
            // lblYearData
            // 
            this.lblYearData.AutoSize = true;
            this.lblYearData.Location = new System.Drawing.Point(485, 133);
            this.lblYearData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYearData.Name = "lblYearData";
            this.lblYearData.Size = new System.Drawing.Size(43, 16);
            this.lblYearData.TabIndex = 5;
            this.lblYearData.Text = "Yakıt :";
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
            this.gbxData.Location = new System.Drawing.Point(17, 321);
            this.gbxData.Margin = new System.Windows.Forms.Padding(5);
            this.gbxData.Name = "gbxData";
            this.gbxData.Padding = new System.Windows.Forms.Padding(5);
            this.gbxData.Size = new System.Drawing.Size(1295, 340);
            this.gbxData.TabIndex = 19;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "Bilgiler";
            // 
            // dgwMyFavorites
            // 
            this.dgwMyFavorites.AllowUserToAddRows = false;
            this.dgwMyFavorites.AllowUserToDeleteRows = false;
            this.dgwMyFavorites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMyFavorites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMyFavorites.Location = new System.Drawing.Point(17, 16);
            this.dgwMyFavorites.Margin = new System.Windows.Forms.Padding(5);
            this.dgwMyFavorites.MultiSelect = false;
            this.dgwMyFavorites.Name = "dgwMyFavorites";
            this.dgwMyFavorites.ReadOnly = true;
            this.dgwMyFavorites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMyFavorites.Size = new System.Drawing.Size(1129, 297);
            this.dgwMyFavorites.TabIndex = 17;
            // 
            // FavoritesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 687);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxData);
            this.Controls.Add(this.dgwMyFavorites);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FavoritesScreen";
            this.Text = "FavoritesScreen";
            this.Load += new System.EventHandler(this.FavoritesScreen_Load);
            this.gbxData.ResumeLayout(false);
            this.gbxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMyFavorites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblKMText;
        private System.Windows.Forms.Label lblKMData;
        private System.Windows.Forms.Label lblYearText;
        private System.Windows.Forms.Label lblColorText;
        private System.Windows.Forms.Label lblUnitPriceText;
        private System.Windows.Forms.Label lblModelText;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblBrandText;
        private System.Windows.Forms.Label lblYearData;
        private System.Windows.Forms.Label lnlColorData;
        private System.Windows.Forms.Label lblUnitPriceData;
        private System.Windows.Forms.Label lblModelData;
        private System.Windows.Forms.Label lblBrandData;
        private System.Windows.Forms.GroupBox gbxData;
        private System.Windows.Forms.DataGridView dgwMyFavorites;
    }
}