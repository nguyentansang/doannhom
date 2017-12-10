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
    public partial class tongdai : Form
    {
        DataTable dsMonAn;
        DataView dsMonAnView;
        DataTable dsChiNhanh;
        DataView dsChiNhanhView;
        DataTable dsdonhang;
        DataTable dskhach;
        DataTable dslichsu;
        int j = 1;
        int i = 0;
        public tongdai()
        {
            InitializeComponent();
        }

        private void tongdai_Load(object sender, EventArgs e)
        {

            dsMonAn = XuLyDuLieu.docBang("select * from MonAn");
            dsMonAnView = new DataView(dsMonAn);
            dgvMonAn.DataSource = dsMonAnView;
            dsChiNhanh = XuLyDuLieu.docBang("select * from ChiNhanh");
            dsChiNhanhView = new DataView(dsChiNhanh);
            dgvChiNhanh.DataSource = dsChiNhanhView;
            comboBox1.DataSource = dsChiNhanh;
            comboBox1.DisplayMember = "TenChiNhanh";
            comboBox1.ValueMember = "MaChiNhanh";
            dsdonhang = XuLyDuLieu.docBang("select * from DonHang");
            dgvDonHang.DataSource = dsdonhang;
            dskhach = XuLyDuLieu.docBang("Select * from Khach");
            dgvKhach.DataSource = dskhach;
            dslichsu = XuLyDuLieu.docBang("Select * from LichSuMua");
            dgvLichSu.DataSource = dslichsu;
        }
        public void AddItem()
        {
            j = 1;
            hoadon.Items.Add(dgvMonAn.SelectedRows[0].Cells["TenMonAn"].Value.ToString());
            hoadon.Items[i].SubItems.Add("1");
            hoadon.Items[i].SubItems.Add(dgvMonAn.SelectedRows[0].Cells["Gia"].Value.ToString());
            i++;
        }
        public void tongtien()
        {
            int t = 0;
            for (int a = 0; a < i; a++)
            {
                t = t + int.Parse(hoadon.Items[a].SubItems[2].Text);
                tbThanhTien.Text = (t).ToString();
            }
            if (t == 0)
                tbThanhTien.Text = "0";
            t = (int.Parse(tbThanhTien.Text) + int.Parse(tbDichVu.Text));
            tbThanhTien.Text = (t - t * int.Parse(tbGiamGia.Text) / 100).ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (hoadon.SelectedItems.Count > 0)
            {
                hoadon.Items.Remove(hoadon.SelectedItems[0]);
            }
            tongtien();
        }

        private void dgvChiNhanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbDichVu_TextChanged(object sender, EventArgs e)
        {
            int dv;
            if (tbDichVu.Text == "")
            {
                dv = 1;
                tbDichVu.Text = dv.ToString();
            }
            else
            {
                dv = int.Parse(tbDichVu.Text);
                tbDichVu.Text = dv.ToString();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (tbGiamGia.Text == "")
                tbGiamGia.Text = "0";
            tongtien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.SelectedRows.Count == 1)
            {


                ListViewItem temp = new ListViewItem();

                int k;
                for (k = 0; k < i; k++)// chay tu dong 0 den dong thu i-1 
                {
                    temp = hoadon.Items[k];
                    if (dgvMonAn.SelectedRows[0].Cells["TenMonAn"].Value.ToString() == temp.Text)
                    {
                        j++;
                        hoadon.Items[k].SubItems[1].Text = j.ToString();
                        int cost = int.Parse(dgvMonAn.SelectedRows[0].Cells["Gia"].Value.ToString()) * j;
                        hoadon.Items[k].SubItems[2].Text = cost.ToString();
                        break;
                    }
                }
                if (k == i)
                {
                    AddItem();
                }
                tongtien();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (hoadon.SelectedItems.Count == 1)
            {
                int soluong = int.Parse((hoadon.SelectedItems[0].SubItems[1].Text));

                if (soluong > 1) 
                {
                    ListViewItem t;
                    t = hoadon.SelectedItems[0];
                    int dongia = 1;
                    for (int i = 0; i < dgvMonAn.Rows.Count; i++)
                    {
                        if (t.Text == dgvMonAn.Rows[i].Cells["TenMonAn"].Value.ToString())
                        {
                            dongia = Convert.ToInt32(dgvMonAn.Rows[i].Cells["Gia"].Value.ToString());
                            break;
                        }
                    }

                    hoadon.SelectedItems[0].SubItems[1].Text = (--soluong).ToString();
                    hoadon.SelectedItems[0].SubItems[2].Text = (dongia * soluong).ToString();
                }
                else
                    while (hoadon.SelectedItems.Count > 0)
                    {
                        hoadon.Items.Remove(hoadon.SelectedItems[0]);
                        i--;
                    }
                tongtien();
            }
            else
            {
                if (hoadon.Items.Count == 0)
                    MessageBox.Show("Bạn cần chọn bên bảng món ăn");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            while (hoadon.SelectedItems.Count > 0)
            {
                hoadon.Items.Remove(hoadon.SelectedItems[0]);
                i--;
            }
            tongtien();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hoadon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            if (dgvChiNhanh.SelectedRows.Count > 0)
            {
                DataRow cn = ((DataRowView)dgvChiNhanh.SelectedRows[0].DataBoundItem).Row;
                DataRow k = ((DataRowView)dgvKhach.SelectedRows[0].DataBoundItem).Row;
                DataRow donhang = dsdonhang.NewRow();
             //   DataRow dh = ((DataRowView)dgvDonHang.SelectedRows[0].DataBoundItem).Row;
                DataRow ls = dslichsu.NewRow();
                donhang["MaDonHang"] = tbMaDonHang.Text;
                donhang["MaChiNhanh"] = cn["MaChiNhanh"];
                donhang["SoDienThoai"] = k["SoDienThoai"];
                donhang["DiaChi"] = k["DiaChi"];
                donhang["ThoiDiem"] = dtp1.Text;
                donhang["TrangThai"] = cbTrangThai.Text;
             //   ls["SoDienThoai"] = k["SoDienThoai"];
             //   ls["MaDonHang"] = dh["MaDonHang"];
             //   ls["ThoiDiem"] = dh["ThoiDiem"];
             //   ls["ThanhTien"] = tbThanhTien.Text;
                dsdonhang.Rows.Add(donhang);
                   ls["SoDienThoai"] = k["SoDienThoai"];
                   ls["MaDonHang"] = donhang["MaDonHang"];
                   ls["ThoiDiem"] = donhang["ThoiDiem"];
                   ls["ThanhTien"] = tbThanhTien.Text;
                 dslichsu.Rows.Add(ls);
                XuLyDuLieu.ghiBang("DonHang",dsdonhang);
                XuLyDuLieu.ghiBang("LichSuMua", dslichsu);
            }
            else
            {
                MessageBox.Show("chon Chi Nhanh", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count > 0)
            {
                DataRow dh = ((DataRowView)dgvDonHang.SelectedRows[0].DataBoundItem).Row;
                dh.Delete();
                XuLyDuLieu.ghiBang("DonHang", dsdonhang);
            }
        }

        private void tbMaDonHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           DataRow kh = dskhach.NewRow();
            kh["SoDienThoai"] = tbSDT.Text;
            kh["DiaChi"] = tbDiaChi.Text;
            kh["Loai"] = cbLoai.Text;
            dskhach.Rows.Add(kh);
            XuLyDuLieu.ghiBang("Khach", dskhach);
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ChiNhanhToan")
            {
                dsMonAn = XuLyDuLieu.docBang("select * from MonAn where MaChiNhanh like '%1%' ");
                dsMonAnView = new DataView(dsMonAn);
                dgvMonAn.DataSource = dsMonAnView;
            }
            else
               if (comboBox1.Text == "ChiNhanhSang")
            {
                dsMonAn = XuLyDuLieu.docBang("select * from MonAn where MaChiNhanh like '%2%'");
                dsMonAnView = new DataView(dsMonAn);
                dgvMonAn.DataSource = dsMonAnView;
            }
            else
            {
                dsMonAn = XuLyDuLieu.docBang("select * from MonAn where MaChiNhanh like '%3%'");
                dsMonAnView = new DataView(dsMonAn);
                dgvMonAn.DataSource = dsMonAnView;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (dgvKhach.SelectedRows.Count > 0)
            {
                DataRow k = ((DataRowView)dgvKhach.SelectedRows[0].DataBoundItem).Row;
                k.Delete();
                XuLyDuLieu.ghiBang("Khach", dskhach);
            }
        }

        private void dgvMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
