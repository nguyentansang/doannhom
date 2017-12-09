using System;
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
    public partial class fDonHangTaiChiNhanh : Form
    {

        public fDonHangTaiChiNhanh()
        {
            InitializeComponent();
        }

        private void fDonHangTaiChiNhanh_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinCaNhan f = new fThongTinCaNhan();
            this.Hide();
            f.ShowDialog();
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTaoTaiKhoan f = new fTaoTaiKhoan();
            this.Hide();
            f.ShowDialog();
        }

        private void đơnHàngTạiChiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDonHangChiNhanh f = new fDonHangChiNhanh();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void đơnHàngMangVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDonHangMangVe f = new fDonHangMangVe();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
