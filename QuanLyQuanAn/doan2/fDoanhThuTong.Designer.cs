namespace doan2
{
    partial class fDoanhThuTong
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
            this.dtgvChiPhi = new System.Windows.Forms.DataGridView();
            this.tbNam = new System.Windows.Forms.TextBox();
            this.tbThang = new System.Windows.Forms.TextBox();
            this.tbNgay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvChiPhi
            // 
            this.dtgvChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiPhi.Location = new System.Drawing.Point(1, 2);
            this.dtgvChiPhi.Name = "dtgvChiPhi";
            this.dtgvChiPhi.Size = new System.Drawing.Size(464, 191);
            this.dtgvChiPhi.TabIndex = 0;
            // 
            // tbNam
            // 
            this.tbNam.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNam.Location = new System.Drawing.Point(182, 318);
            this.tbNam.Name = "tbNam";
            this.tbNam.Size = new System.Drawing.Size(283, 29);
            this.tbNam.TabIndex = 25;
            // 
            // tbThang
            // 
            this.tbThang.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThang.Location = new System.Drawing.Point(182, 270);
            this.tbThang.Name = "tbThang";
            this.tbThang.Size = new System.Drawing.Size(283, 29);
            this.tbThang.TabIndex = 26;
            // 
            // tbNgay
            // 
            this.tbNgay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgay.Location = new System.Drawing.Point(182, 221);
            this.tbNgay.Name = "tbNgay";
            this.tbNgay.Size = new System.Drawing.Size(283, 29);
            this.tbNgay.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "Năm";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tháng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ngày";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fDoanhThuTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 406);
            this.Controls.Add(this.tbNam);
            this.Controls.Add(this.tbThang);
            this.Controls.Add(this.tbNgay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvChiPhi);
            this.Name = "fDoanhThuTong";
            this.Text = "fDoanhThuTong";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.fDoanhThuTong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChiPhi;
        private System.Windows.Forms.TextBox tbNam;
        private System.Windows.Forms.TextBox tbThang;
        private System.Windows.Forms.TextBox tbNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}