using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace doan2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void mụcTiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MucTieu m = new MucTieu();
            m.Show();
            this.Close();
        }
        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
          /*  CacThanhPhanHeThong x = new CacThanhPhanHeThong();
            x.Show();
            this.Close();*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            bophanquanli bql = new bophanquanli();
            bql.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tạoĐơnHàngPhụcVụTạiChiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDonHangTaiChiNhanh f = new fDonHangTaiChiNhanh();
            f.Show();
        }

        private void bộPhậnQuảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bophanquanli bpql = new bophanquanli();
            bpql.Show();
        }

        private void hoạtĐộngBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDonHangChiNhanh dhcn = new fDonHangChiNhanh();
            dhcn.Show();
        }

        private void tạoĐơnHàngChoKháchKhiCóCuộcGọiĐếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tongdai td = new tongdai();
            td.Show();
        }

        private void hoạtĐộngTổngĐàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tongdai td = new tongdai();
            td.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            tongdai td = new tongdai();
            td.Show();
        }

        private void tạoĐơnHàngMangVềTạiChiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDonHangMangVe f = new fDonHangMangVe();
            f.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void nhậpChiPhíPhátSinhChoQuánTrongNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChiPhiPhatSinhNgay f = new fChiPhiPhatSinhNgay();
            f.ShowDialog();
        }

        private void nhậpChiPhíPhátSinhChoQuánTrongThángmỗiThángNhập1LầnTiềnThuêNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChiPhiPhatSinhThang f = new fChiPhiPhatSinhThang();
            f.ShowDialog();
        }

        /*private void label1_Click(object sender, EventArgs e)
        {
            int start = label1.Left();
            while (label1.Left < this.Width - label1.Left)
            {
                label1.Left += 5;
                Application.DoEvents();
                Thread.Sleep(30);
                if(label1.Left >= this.Width - label1.Left)
                {
                    label1.Left = start;
                }
            }

        }*/
    }
}
