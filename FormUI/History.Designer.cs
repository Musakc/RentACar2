namespace FormUI
{
    partial class History
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
            this.dgwProductHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwProductHistory
            // 
            this.dgwProductHistory.AllowUserToAddRows = false;
            this.dgwProductHistory.AllowUserToDeleteRows = false;
            this.dgwProductHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProductHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProductHistory.Location = new System.Drawing.Point(91, 28);
            this.dgwProductHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dgwProductHistory.MultiSelect = false;
            this.dgwProductHistory.Name = "dgwProductHistory";
            this.dgwProductHistory.ReadOnly = true;
            this.dgwProductHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProductHistory.Size = new System.Drawing.Size(747, 286);
            this.dgwProductHistory.TabIndex = 14;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.dgwProductHistory);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProductHistory;
    }
}