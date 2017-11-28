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
    public partial class bophanquanli : Form
    {
        DataTable dsChiNhanh;
        DataView dsChiNhanhView;
        DataTable dsBan;
        DataTable dsMonAn;
        DataTable dsDanhMuc;
        public bophanquanli()
        {
            InitializeComponent();
        }

        private void bophanquanli_Load(object sender, EventArgs e)
        {
            dsChiNhanh = XuLyDuLieu.docBang("select * from ChiNhanh");
            dsChiNhanhView = new DataView(dsChiNhanh);
            dgvChiNhanh.DataSource = dsChiNhanhView;
            dsBan = XuLyDuLieu.docBang("select * from Ban");
            dgvBan.DataSource = dsBan;
            dsMonAn = XuLyDuLieu.docBang("select * from MonAn");
            dgvMonAn.DataSource = dsMonAn;
            dsDanhMuc = XuLyDuLieu.docBang("select *from DanhMuc");
            dgvDanhMuc.DataSource = dsDanhMuc;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvChiNhanh.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvChiNhanh.SelectedRows[0].DataBoundItem).Row;
                cn["TenChiNhanh"] = tbTenChiNhanh.Text;
                cn["SDTChiNhanh"] = tbDienThoai.Text;
                cn["DiaChiChiNhanh"] = tbDiaChi.Text;
                cn["MaChiNhanh"] = tbMaCN.Text;
                cn["TinhThanh"] = tbTinhThanh.Text;
                XuLyDuLieu.ghiBang("ChiNhanh", dsChiNhanh);
            }
            else
            {
                MessageBox.Show("Chua Chon Chi Nhanh", "Thong Bao", MessageBoxButtons.OK)
;            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvBan.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvBan.SelectedRows[0].DataBoundItem).Row;
                cn.Delete();
                XuLyDuLieu.ghiBang("Ban", dsBan);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvBan.SelectedRows.Count > 0)
            {
                DataRow ban = ((DataRowView)dgvBan.SelectedRows[0].DataBoundItem).Row;
                ban["BMa"] = tbMaBan.Text;
                ban["BTen"] = tbTenBan.Text;
                XuLyDuLieu.ghiBang("ChiNhanh", dsChiNhanh);
            }
            else
            {
                MessageBox.Show("Chua Chon Chi Nhanh", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvChiNhanh.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvChiNhanh.SelectedRows[0].DataBoundItem).Row;
                DataRow monan = dsMonAn.NewRow();
                monan["Mama"] = tbMaMonAn.Text;
                monan["Gia"] = tbGia.Text;
                monan["GhiChu"] = tbTenMonAn.Text;
                monan["MaCN"] = cn["CNMa"];
                dsMonAn.Rows.Add(monan);
                XuLyDuLieu.ghiBang("MonAn", dsMonAn);
            }
            else
            {
                MessageBox.Show("chon Chi Nhanh", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvMonAn.SelectedRows[0].DataBoundItem).Row;
                cn.Delete();
                XuLyDuLieu.ghiBang("MonAn", dsMonAn);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.SelectedRows.Count > 0)
            {
                DataRow monan = ((DataRowView)dgvMonAn.SelectedRows[0].DataBoundItem).Row;
                monan["Mama"] = tbMaMonAn.Text;
                monan["Gia"] = tbGia.Text;
                monan["GhiChu"] = tbTenMonAn.Text;
                XuLyDuLieu.ghiBang("ChiNhanh", dsChiNhanh);
            }
            else
            {
                MessageBox.Show("Chua Chon Chi Nhanh", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Close();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataRow cn = dsChiNhanh.NewRow();
            cn["MaChiNhanh"] = tbMaCN.Text;
            cn["TenChiNhanh"] = tbTenChiNhanh.Text;
            cn["SDTChiNhanh"] = tbDienThoai.Text;
            cn["DiaChiChiNhanh"] = tbDiaChi.Text;
            cn["TinhThanh"] = tbTinhThanh.Text;
            dsChiNhanh.Rows.Add(cn);
            XuLyDuLieu.ghiBang("ChiNhanh", dsChiNhanh);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {

            if (dgvChiNhanh.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvChiNhanh.SelectedRows[0].DataBoundItem).Row;
                cn.Delete();
                XuLyDuLieu.ghiBang("ChiNhanh", dsChiNhanh);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dgvChiNhanh.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvChiNhanh.SelectedRows[0].DataBoundItem).Row;
                cn["TenChiNhanh"] = tbTenChiNhanh.Text;
                cn["SDTChiNhanh"] = tbDienThoai.Text;
                cn["DiaChiChiNhanh"] = tbDiaChi.Text;
                cn["MaChiNhanh"] = tbMaCN.Text;
                cn["TinhThanh"] = tbTinhThanh.Text;
                XuLyDuLieu.ghiBang("ChiNhanh", dsChiNhanh);
            }
            else
            {
                MessageBox.Show("Chua Chon Chi Nhanh", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void tbTimKiemChiNhanh_TextChanged_1(object sender, EventArgs e)
        {
            if (tbTimKiemChiNhanh.Text == "")
            {
                dsChiNhanhView.RowFilter = "";
            }
            else
            {
                String str = String.Format("TenChiNhanh like '%{0}%'", tbTimKiemChiNhanh.Text);
                //muon tim kiem nhieu hon nua
                //String str = String.Format("CNTen like '%{0}%' or "CNMa like '%{1}%'",tbTimKiemChiNhanh.Text,tbTimKiemChiNhanh1.Text);
                dsChiNhanhView.RowFilter = str;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dgvChiNhanh.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvChiNhanh.SelectedRows[0].DataBoundItem).Row;
                DataRow ban = dsBan.NewRow();
                ban["MaBan"] = tbMaBan.Text;
                ban["TenBan"] = tbTenBan.Text;
                ban["MaChiNhanh"] = cn["MaChiNhanh"];
                ban["TrangThai"] = tbTrangThai.Text;
                dsBan.Rows.Add(ban);
                XuLyDuLieu.ghiBang("Ban", dsBan);
            }
            else
            {
                MessageBox.Show("chon Chi Nhanh", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (dgvBan.SelectedRows.Count > 0)
            {
                DataRow b = ((DataRowView)dgvBan.SelectedRows[0].DataBoundItem).Row;
               b.Delete();
                XuLyDuLieu.ghiBang("Ban", dsBan);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (dgvBan.SelectedRows.Count > 0)
            {
                DataRow b = ((DataRowView)dgvBan.SelectedRows[0].DataBoundItem).Row;
                b["MaBan"] = tbMaBan.Text;
                b["TenBan"] = tbTenBan.Text;
                XuLyDuLieu.ghiBang("ChiNhanh", dsChiNhanh);
            }
            else
            {
                MessageBox.Show("Chua Chon Chi Nhanh", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (dgvChiNhanh.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvChiNhanh.SelectedRows[0].DataBoundItem).Row;
                DataRow dm = ((DataRowView)dgvDanhMuc.SelectedRows[0].DataBoundItem).Row;
                DataRow monan = dsMonAn.NewRow();
                monan["MaMonAn"] = tbMaMonAn.Text;
                monan["TenMonAn"] = tbTenMonAn.Text;
                monan["Gia"] = tbGia.Text;
                monan["MaChiNhanh"] = cn["MaChiNhanh"];
                monan["MaDanhMuc"] = dm["MaDanhMuc"];
                dsMonAn.Rows.Add(monan);
                XuLyDuLieu.ghiBang("MonAn", dsMonAn);
            }
            else
            {
                MessageBox.Show("chon Chi Nhanh", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (dgvMonAn.SelectedRows.Count > 0)
            {
                DataRow ma = ((DataRowView)dgvMonAn.SelectedRows[0].DataBoundItem).Row;
                ma.Delete();
                XuLyDuLieu.ghiBang("MonAn", dsMonAn);
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (dgvMonAn.SelectedRows.Count > 0)
            {
                DataRow monan = ((DataRowView)dgvMonAn.SelectedRows[0].DataBoundItem).Row;
                DataRow dm = ((DataRowView)dgvDanhMuc.SelectedRows[0].DataBoundItem).Row;
                monan["MaMonAn"] = tbMaMonAn.Text;
                monan["Gia"] = tbGia.Text;
                monan["TenMonAn"] = tbTenMonAn.Text;
                XuLyDuLieu.ghiBang("ChiNhanh", dsChiNhanh);
                XuLyDuLieu.ghiBang("DanhMuc", dsDanhMuc);
            }
            else
            {
                MessageBox.Show("Chua Chon Chi Nhanh", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void dgvMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbMaCN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (dgvChiNhanh.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvChiNhanh.SelectedRows[0].DataBoundItem).Row;
                DataRow dm = dsDanhMuc.NewRow();
                dm["MaDanhMuc"] = tbMaDanhMuc.Text;
                dm["TenDanhMuc"] = tbTenDanhMuc.Text;
                dm["MaChiNhanh"] = cn["MaChiNhanh"];
                dsDanhMuc.Rows.Add(dm);
                XuLyDuLieu.ghiBang("DanhMuc",dsDanhMuc);
            }
            else
            {
                MessageBox.Show("chon Chi Nhanh", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (dgvDanhMuc.SelectedRows.Count > 0)
            {
                DataRow dm = ((DataRowView)dgvDanhMuc.SelectedRows[0].DataBoundItem).Row;
                dm.Delete();
                XuLyDuLieu.ghiBang("Ban", dsBan);
            }
        }
    }
}

