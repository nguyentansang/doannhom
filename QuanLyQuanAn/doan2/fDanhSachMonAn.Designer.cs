namespace doan2
{
    partial class fDanhSachMonAn
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
            this.dtgvMonAn = new System.Windows.Forms.DataGridView();
            this.btThoatDanhSachMonAn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMonAn
            // 
            this.dtgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonAn.Location = new System.Drawing.Point(-2, -1);
            this.dtgvMonAn.Name = "dtgvMonAn";
            this.dtgvMonAn.Size = new System.Drawing.Size(726, 346);
            this.dtgvMonAn.TabIndex = 0;
            this.dtgvMonAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMonAn_CellContentClick);
            // 
            // btThoatDanhSachMonAn
            // 
            this.btThoatDanhSachMonAn.Location = new System.Drawing.Point(286, 370);
            this.btThoatDanhSachMonAn.Name = "btThoatDanhSachMonAn";
            this.btThoatDanhSachMonAn.Size = new System.Drawing.Size(124, 45);
            this.btThoatDanhSachMonAn.TabIndex = 1;
            this.btThoatDanhSachMonAn.Text = "Thoát";
            this.btThoatDanhSachMonAn.UseVisualStyleBackColor = true;
            this.btThoatDanhSachMonAn.Click += new System.EventHandler(this.btThoatDanhSachMonAn_Click);
            // 
            // fDanhSachMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 427);
            this.Controls.Add(this.btThoatDanhSachMonAn);
            this.Controls.Add(this.dtgvMonAn);
            this.Name = "fDanhSachMonAn";
            this.Text = "fDanhSachMonAn";
            this.Load += new System.EventHandler(this.fDanhSachMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMonAn;
        private System.Windows.Forms.Button btThoatDanhSachMonAn;
    }
}