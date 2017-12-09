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
    public partial class fDonHangChiNhanh : Form
    {
        int i = 0;
        int j = 1;
        DataTable dsMonAn;
        DataView dsMonAnView;
        DataTable dsChiNhanh;
       // DataTable dsBan;

        public fDonHangChiNhanh()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private void fDonHangChiNhanh_Load(object sender, EventArgs e)
        {
            //dsMonAn = XuLyDuLieu.docBang("select * from MonAn");
            //dsMonAnView = new DataView(dsMonAn);
            //dtgvDanhSachMonAn.DataSource = dsMonAnView;

            dsChiNhanh = XuLyDuLieu.docBang("select * from ChiNhanh");
            cbChiNhanh.DataSource = dsChiNhanh;
            cbChiNhanh.DisplayMember = "TenChiNhanh";
            cbChiNhanh.ValueMember = "MaChiNhanh";
        }
        public void AddItem()
        {
            j = 1;
            lvHoaDon.Items.Add(dtgvDanhSachMonAn.SelectedRows[0].Cells["TenMonAn"].Value.ToString());
            lvHoaDon.Items[i].SubItems.Add("1");
            lvHoaDon.Items[i].SubItems.Add(dtgvDanhSachMonAn.SelectedRows[0].Cells["TenMonAn"].Value.ToString());
            lvHoaDon.Items[i].SubItems.Add(dtgvDanhSachMonAn.SelectedRows[0].Cells["Gia"].Value.ToString());
            i++;
        }
        public void TienHoaDon()
        {
            int hd = 0;
            for (int a = 0; a < i; a++)
            {
                hd = hd + int.Parse(lvHoaDon.Items[a].SubItems[3].Text);
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
                gg = 100;
                tbGiamGia.Text = gg.ToString();
            }
            else if (tbMaGiamGia.Text == "KhachChiNhanh")
                 {
                    gg = 1;
                    tbGiamGia.Text = gg.ToString();
                 }
                 else if(tbMaGiamGia.Text == "KhachVipChiNhanh")
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
            if(tbGiamGia.Text == "100")
            {
                tt = hd + dv;
                //tt = hd;
                tbThanhTien.Text = tt.ToString();
            }
            else
            {
                tt = hd -(( hd * gg )/ 100 )+ dv;
                //tt = hd - ((hd * gg) / 100);
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

        private void tbThanhTien_TextChanged(object sender, EventArgs e)
        {

        }



        private void btThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã in !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvDanhSachBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChiNhanh.Text == "ChiNhanhToan")
            {
                dsMonAn = XuLyDuLieu.docBang("select * from MonAn where MaChiNhanh like '%1%' ");
                dsMonAnView = new DataView(dsMonAn);
                dtgvDanhSachMonAn.DataSource = dsMonAnView;

               // dsBan = XuLyDuLieu.docBang("select * from Ban where MaChiNhanh like '%1%' ");

               // ListViewItem t = new ListViewItem();
              //  for (int i = 0; i < dsBan.Rows.Count; i++)
              //  {
                  //  t = lvDanhSachBan.Items[i].SubItems[0];
                //    lvDanhSachBan.Items.Add(dsBan.Rows[i]["TenBan"].ToString());
                    //t.SubItems.Add(dsBan.Rows[i]["TenBan"].ToString());
              //  }
                    //t = lvDanhSachBan.Items[i];

                    //int cost = XuLyDuLieu.
                    //lvDanhSachBan.Items[i].SubItems[1].Text = 
                    //ListViewItem lv = lvDanhSachBan.Items.Add(dsBan.Rows[i]["MaDH"].ToString());
                    //lv.SubItems.Add(dsBan.Rows[i]["Ban"].ToString());

                   /* int k;
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
                }*/
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
    }
}
