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
    public partial class fDonHangMangVe : Form
    {
        int i = 0;
        int j = 1;
        DataTable dsMonAn;
        DataView dsMonAnView;
        DataTable dsChiNhanh;
        DataTable dsDonHang;
        DataTable dsLichSu;
        public fDonHangMangVe()
        {
            InitializeComponent();
        }

        private void fDonHangMangVe_Load(object sender, EventArgs e)
        {
            dsChiNhanh = XuLyDuLieu.docBang("select * from ChiNhanh");
            cbChiNhanh.DataSource = dsChiNhanh;
            cbChiNhanh.DisplayMember = "TenChiNhanh";
            cbChiNhanh.ValueMember = "MaChiNhanh";
            dsDonHang = XuLyDuLieu.docBang("select * from DonHang");
            dtgvDonHang.DataSource = dsDonHang;
            dsLichSu = XuLyDuLieu.docBang("Select * from LichSuMua");
            dtgvLichSu.DataSource = dsLichSu;
        }
        public void AddItem()
        {
            j = 1;
            lvHoaDon.Items.Add(dtgvDanhSachMonAn.SelectedRows[0].Cells["TenMonAn"].Value.ToString());
            lvHoaDon.Items[i].SubItems.Add("1");
            lvHoaDon.Items[i].SubItems.Add(dtgvDanhSachMonAn.SelectedRows[0].Cells["Gia"].Value.ToString());
            i++;
        }
        public void TienHoaDon()
        {
            int hd = 0;
            for (int a = 0; a < i; a++)
            {
                hd = hd + int.Parse(lvHoaDon.Items[a].SubItems[2].Text);
                tbTienHoaDon.Text = (hd).ToString();
            }
            if (hd == 0)
                tbTienHoaDon.Text = "0";
            hd = (int.Parse(tbTienHoaDon.Text));
            tbTienHoaDon.Text = hd.ToString();
        }
        public void GiamGia()
        {
            int gg;
            if (tbMaGiamGia.Text == "")
            {
                MessageBox.Show("Quý Khách Có Chắc Không Cần Giảm Giá");
                gg = 0;
                tbGiamGia.Text = gg.ToString();
            }
            else if (tbMaGiamGia.Text == "KhachChiNhanh")
            {
                gg = 1;
                tbGiamGia.Text = gg.ToString();
            }
            else if (tbMaGiamGia.Text == "KhachVipChiNhanh")
            {
                gg = 2;
                tbGiamGia.Text = gg.ToString();
            }
            else
            {
                MessageBox.Show("Quý Khách Nhập Sai Mã Giảm Giá");
            }
        }
        public void ThanhTien()
        {
            int tt;
            int dv;
            int hd = int.Parse(tbTienHoaDon.Text);
            int gg = int.Parse(tbGiamGia.Text);
            if (tbChiPhiDichVu.Text == "")
            {
                dv = 0;
            }
            else
            {
                dv = int.Parse(tbChiPhiDichVu.Text);
            }
            if (tbGiamGia.Text == "0")
            {
                tt = hd + dv;
                tbThanhTien.Text = tt.ToString();
            }
            else
            {
                tt = hd - ((hd * gg) / 100) + dv;
                tbThanhTien.Text = tt.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachMonAn.SelectedRows.Count == 1)
            {
                ListViewItem temp = new ListViewItem();

                int k;
                for (k = 0; k < i; k++)
                {
                    temp = lvHoaDon.Items[k];
                    if (dtgvDanhSachMonAn.SelectedRows[0].Cells["TenMonAn"].Value.ToString() == temp.Text)
                    {
                        j++;
                        lvHoaDon.Items[k].SubItems[1].Text = j.ToString();

                        int cost = int.Parse(dtgvDanhSachMonAn.SelectedRows[0].Cells["Gia"].Value.ToString()) * j;
                        lvHoaDon.Items[k].SubItems[2].Text = cost.ToString();
                        break;
                    }
                }
                if (k == i)
                {
                    AddItem();
                }
                TienHoaDon();
            }
            else
                MessageBox.Show("Mỗi Lần Bạn Chỉ Nên Chọn 1 Món!");
        }

        private void btBot_Click(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count == 1)
            {
                int soluong = int.Parse((lvHoaDon.SelectedItems[0].SubItems[1].Text));

                if (soluong > 1)
                {
                    ListViewItem t;
                    t = lvHoaDon.SelectedItems[0];
                    int dongia = 1;
                    for (int i = 0; i < dtgvDanhSachMonAn.Rows.Count; i++)
                    {
                        if (t.Text == dtgvDanhSachMonAn.Rows[i].Cells["TenMonAn"].Value.ToString())
                        {
                            dongia = Convert.ToInt32(dtgvDanhSachMonAn.Rows[i].Cells["Gia"].Value.ToString());
                            break;
                        }
                    }

                    lvHoaDon.SelectedItems[0].SubItems[1].Text = (--soluong).ToString();
                    lvHoaDon.SelectedItems[0].SubItems[2].Text = (dongia * soluong).ToString();


                }
                else
                    while (lvHoaDon.SelectedItems.Count > 0)
                    {
                        lvHoaDon.Items.Remove(lvHoaDon.SelectedItems[0]);
                        i--;
                    }
                TienHoaDon();
            }
            else
            {
                if (lvHoaDon.Items.Count == 0 || lvHoaDon.SelectedItems.Count > 1 || lvHoaDon.SelectedItems.Count == 0)
                    MessageBox.Show("Qúy Khách Đã Sai Thao Tác");
            }
        }

        private void tbTimMonAn_TextChanged(object sender, EventArgs e)
        {
            if (tbTimMonAn.Text == "")
            {
                MessageBox.Show("Quý Khách chưa nhập từ khóa tìm kiếm");
            }
            else
            {
                String str = String.Format("TenMonAn like '%{0}%' ", tbTimMonAn.Text);
                dsMonAnView.RowFilter = str;
            }
        }
        private void btThanhTien_Click(object sender, EventArgs e)
        {
            GiamGia();
            ThanhTien();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã in !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChiNhanh.Text == "ChiNhanhToan")
            {
                dsMonAn = XuLyDuLieu.docBang("select * from MonAn where MaChiNhanh like '%1%' ");
                dsMonAnView = new DataView(dsMonAn);
                dtgvDanhSachMonAn.DataSource = dsMonAnView;
            }
            else
    if (cbChiNhanh.Text == "ChiNhanhSang")
            {
                dsMonAn = XuLyDuLieu.docBang("select * from MonAn where MaChiNhanh like '%2%'");
                dsMonAnView = new DataView(dsMonAn);
                dtgvDanhSachMonAn.DataSource = dsMonAnView;
            }
            else
            {
                dsMonAn = XuLyDuLieu.docBang("select * from MonAn where MaChiNhanh like '%3%'");
                dsMonAnView = new DataView(dsMonAn);
                dtgvDanhSachMonAn.DataSource = dsMonAnView;
            }
        }

        private void btDonHang_Click(object sender, EventArgs e)
        {
            if (tbMaDonHang.Text != "" || tbSoDienThoai.Text != "" || tbDiaChi.Text != "")
            {
                DataRow donhang = dsDonHang.NewRow();
                dsDonHang.Rows.Add(donhang);
                donhang["MaDonHang"] = tbMaDonHang.Text;
                donhang["MaChiNhanh"] = cbChiNhanh.SelectedValue;
                donhang["SoDienThoai"] = tbSoDienThoai.Text;
                donhang["DiaChi"] = tbDiaChi.Text;
                donhang["ThoiDiem"] = dtpNgayMua.Text;
                donhang["TrangThai"] = "Chưa Thanh Toán";
                donhang["Loai"] = "2";
                XuLyDuLieu.ghiBang("DonHang", dsDonHang);
            }
            else
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        private void btLichSu_Click(object sender, EventArgs e)
        {
            if (tbThanhTien.Text == "")
            {
                MessageBox.Show("Bạn Chưa Bấm Tổng Cộng", "Thông Báo", MessageBoxButtons.OK);
            }
            else
    if (tbMaDonHang.Text != "" || tbSoDienThoai.Text != "")
            {
                DataRow ls = dsLichSu.NewRow();
                ls["SoDienThoai"] = tbSoDienThoai.Text;
                ls["MaDonHang"] = tbMaDonHang.Text;
                ls["NgayMua"] = dtpNgayMua.Text;
                ls["NgayGiao"] = dtpNgayGiao.Text;
                ls["TongCong"] = tbThanhTien.Text;
                dsLichSu.Rows.Add(ls);

                XuLyDuLieu.ghiBang("LichSuMua", dsLichSu);
            }
            else
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btXuongBep_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã Xuống Bếp");
        }
    }
}
