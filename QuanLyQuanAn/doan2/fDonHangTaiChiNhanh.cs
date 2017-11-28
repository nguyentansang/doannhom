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
        DataTable dsDonHang;
        DataView dsDonHangView;
        DataTable dsDonHangChiTiet;
        DataView dsDonHangChiTietView;
        DataTable dsChiNhanh;


        public fDonHangTaiChiNhanh()
        {
            InitializeComponent();
        }

        private void btXemMonAn_Click(object sender, EventArgs e)
        {
            fDanhSachMonAn f = new fDanhSachMonAn();
            f.Show();
        }

        private void fDonHangTaiChiNhanh_Load(object sender, EventArgs e)
        {
            dsDonHang = XuLyDuLieu.docBang("select * from DonHang");
            dsDonHangView = new DataView(dsDonHang);
            dtgvDonHangCN.DataSource = dsDonHangView;

            dsDonHangChiTiet = XuLyDuLieu.docBang("select * from DonHangChiTiet");
            dsDonHangChiTietView = new DataView(dsDonHangChiTiet);
            dtgvDonHangCTCN.DataSource = dsDonHangChiTietView;

            dsChiNhanh = XuLyDuLieu.docBang("select *from ChiNhanh");
            cbMaChiNhanhCN.DataSource = dsChiNhanh;
            cbMaChiNhanhCN.DisplayMember = "TenChiNhanh";
            cbMaChiNhanhCN.ValueMember = "MaChiNhanh";
        }

        private void btTaoDonHang_Click(object sender, EventArgs e)
        {
            if(tbMaDonHangCN.Text != "")
            {
                //DataRow dhcn = ((DataRowView)dtgvDonHangCN.SelectedRows[0].DataBoundItem).Row;
                //dhcn["MaDonHang"] = tbMaDonHangCN.Text;
                //dhcn["MaChiNhanh"] = cbMaChiNhanhCN.Text;
                //dhcn["ThoiDiem"] = dtpThoiGianCN;
                //dhcn["TrangThai"] = nUDSoLuong;
                dsDonHang.DefaultView.RowFilter = string.Format("MaChiNhanh LIKE '%{0}%'",cbMaChiNhanhCN.Text);

            }
            else
            {
                MessageBox.Show("Chua Chon Chi Nhanh", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void cbMaChiNhanhCN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
