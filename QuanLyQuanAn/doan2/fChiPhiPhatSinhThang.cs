﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan2
{
    public partial class fChiPhiPhatSinhThang : Form
    {
        public fChiPhiPhatSinhThang()
        {
            InitializeComponent();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập Thành Công");
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fChiPhiPhatSinhThang_Load(object sender, EventArgs e)
        {

        }
    }
}