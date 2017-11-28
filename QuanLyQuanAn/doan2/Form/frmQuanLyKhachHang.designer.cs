namespace WindowsFormsApplication1
{
    partial class frmQuanLyKhachHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbTimKiemKH = new System.Windows.Forms.TextBox();
            this.btThemKH = new System.Windows.Forms.Button();
            this.btXoaKH = new System.Windows.Forms.Button();
            this.btSuaKH = new System.Windows.Forms.Button();
            this.tbMaLoaiKH = new System.Windows.Forms.TextBox();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.lbMaLKH = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.gbThongTinKH = new System.Windows.Forms.GroupBox();
            this.btTaoDonHang = new System.Windows.Forms.Button();
            this.gbBangDS = new System.Windows.Forms.GroupBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbThongTinKH.SuspendLayout();
            this.gbBangDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbTimKiemKH
            // 
            this.tbTimKiemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiemKH.Location = new System.Drawing.Point(536, 184);
            this.tbTimKiemKH.Name = "tbTimKiemKH";
            this.tbTimKiemKH.Size = new System.Drawing.Size(140, 29);
            this.tbTimKiemKH.TabIndex = 1;
            this.tbTimKiemKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btThemKH
            // 
            this.btThemKH.Location = new System.Drawing.Point(29, 177);
            this.btThemKH.Name = "btThemKH";
            this.btThemKH.Size = new System.Drawing.Size(75, 35);
            this.btThemKH.TabIndex = 3;
            this.btThemKH.Text = "Thêm";
            this.btThemKH.UseVisualStyleBackColor = true;
            // 
            // btXoaKH
            // 
            this.btXoaKH.Location = new System.Drawing.Point(129, 177);
            this.btXoaKH.Name = "btXoaKH";
            this.btXoaKH.Size = new System.Drawing.Size(75, 35);
            this.btXoaKH.TabIndex = 4;
            this.btXoaKH.Text = "Xóa";
            this.btXoaKH.UseVisualStyleBackColor = true;
            // 
            // btSuaKH
            // 
            this.btSuaKH.Location = new System.Drawing.Point(231, 177);
            this.btSuaKH.Name = "btSuaKH";
            this.btSuaKH.Size = new System.Drawing.Size(77, 35);
            this.btSuaKH.TabIndex = 5;
            this.btSuaKH.Text = "Sửa";
            this.btSuaKH.UseVisualStyleBackColor = true;
            this.btSuaKH.Click += new System.EventHandler(this.btSuaKH_Click);
            // 
            // tbMaLoaiKH
            // 
            this.tbMaLoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaLoaiKH.Location = new System.Drawing.Point(430, 29);
            this.tbMaLoaiKH.Name = "tbMaLoaiKH";
            this.tbMaLoaiKH.Size = new System.Drawing.Size(147, 26);
            this.tbMaLoaiKH.TabIndex = 6;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaKH.Location = new System.Drawing.Point(117, 29);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(164, 26);
            this.tbMaKH.TabIndex = 7;
            this.tbMaKH.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbTenKH
            // 
            this.tbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKH.Location = new System.Drawing.Point(117, 61);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(164, 26);
            this.tbTenKH.TabIndex = 8;
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Location = new System.Drawing.Point(430, 61);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(147, 26);
            this.tbSDT.TabIndex = 9;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(116, 97);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(460, 26);
            this.tbDiaChi.TabIndex = 10;
            // 
            // lbMaLKH
            // 
            this.lbMaLKH.AutoSize = true;
            this.lbMaLKH.Location = new System.Drawing.Point(313, 32);
            this.lbMaLKH.Name = "lbMaLKH";
            this.lbMaLKH.Size = new System.Drawing.Size(111, 13);
            this.lbMaLKH.TabIndex = 11;
            this.lbMaLKH.Text = "Mã Loại Khách Hàng ";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(23, 32);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(85, 13);
            this.lbMaKH.TabIndex = 12;
            this.lbMaKH.Text = "Mã Khách Hàng";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(23, 64);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(89, 13);
            this.lbTenKH.TabIndex = 13;
            this.lbTenKH.Text = "Tên Khách Hàng";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(66, 94);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(41, 13);
            this.lbDiaChi.TabIndex = 14;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(340, 64);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(75, 13);
            this.lbSDT.TabIndex = 15;
            this.lbSDT.Text = "Số Điện Thoại";
            // 
            // gbThongTinKH
            // 
            this.gbThongTinKH.Controls.Add(this.btTaoDonHang);
            this.gbThongTinKH.Controls.Add(this.lbMaLKH);
            this.gbThongTinKH.Controls.Add(this.lbSDT);
            this.gbThongTinKH.Controls.Add(this.tbMaLoaiKH);
            this.gbThongTinKH.Controls.Add(this.lbDiaChi);
            this.gbThongTinKH.Controls.Add(this.tbMaKH);
            this.gbThongTinKH.Controls.Add(this.lbTenKH);
            this.gbThongTinKH.Controls.Add(this.tbTenKH);
            this.gbThongTinKH.Controls.Add(this.lbMaKH);
            this.gbThongTinKH.Controls.Add(this.tbSDT);
            this.gbThongTinKH.Controls.Add(this.tbDiaChi);
            this.gbThongTinKH.Location = new System.Drawing.Point(27, 21);
            this.gbThongTinKH.Name = "gbThongTinKH";
            this.gbThongTinKH.Size = new System.Drawing.Size(739, 143);
            this.gbThongTinKH.TabIndex = 16;
            this.gbThongTinKH.TabStop = false;
            this.gbThongTinKH.Text = "Thông Tin Khách Hàng";
            // 
            // btTaoDonHang
            // 
            this.btTaoDonHang.Location = new System.Drawing.Point(604, 29);
            this.btTaoDonHang.Name = "btTaoDonHang";
            this.btTaoDonHang.Size = new System.Drawing.Size(108, 58);
            this.btTaoDonHang.TabIndex = 16;
            this.btTaoDonHang.Text = "Tạo Đơn Hàng";
            this.btTaoDonHang.UseVisualStyleBackColor = true;
            // 
            // gbBangDS
            // 
            this.gbBangDS.Controls.Add(this.dataGridView1);
            this.gbBangDS.Location = new System.Drawing.Point(27, 235);
            this.gbBangDS.Name = "gbBangDS";
            this.gbBangDS.Size = new System.Drawing.Size(739, 267);
            this.gbBangDS.TabIndex = 17;
            this.gbBangDS.TabStop = false;
            this.gbBangDS.Text = "Bảng Danh Sách";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(682, 177);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(79, 40);
            this.btTimKiem.TabIndex = 18;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 513);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.gbBangDS);
            this.Controls.Add(this.gbThongTinKH);
            this.Controls.Add(this.btSuaKH);
            this.Controls.Add(this.btXoaKH);
            this.Controls.Add(this.btThemKH);
            this.Controls.Add(this.tbTimKiemKH);
            this.Name = "frmQuanLyKhachHang";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbThongTinKH.ResumeLayout(false);
            this.gbThongTinKH.PerformLayout();
            this.gbBangDS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbTimKiemKH;
        private System.Windows.Forms.Button btThemKH;
        private System.Windows.Forms.Button btXoaKH;
        private System.Windows.Forms.Button btSuaKH;
        private System.Windows.Forms.TextBox tbMaLoaiKH;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label lbMaLKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.GroupBox gbThongTinKH;
        private System.Windows.Forms.GroupBox gbBangDS;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btTaoDonHang;
    }
}

