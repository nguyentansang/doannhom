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
    public partial class fThongTinCaNhan : Form
    {
        DataTable dskhach;

        public fThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            DataRow kh = dskhach.NewRow();
            kh["SoDienThoai"] = tbSoDienThoai.Text;
            kh["DiaChi"] = tbDiaChi.Text;

            dskhach.Rows.Add(kh);
            XuLyDuLieu.ghiBang("Khach", dskhach);
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThongTinCaNhan_Load(object sender, EventArgs e)
        {
            dskhach = XuLyDuLieu.docBang("Select * from Khach");
            dtgvKhachHang.DataSource = dskhach;
        }
    }
}
