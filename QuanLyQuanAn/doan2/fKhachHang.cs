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
    public partial class fKhachHang : Form
    {
        DataTable dsKhachHang;
        DataView dsKhachHangView;
        public fKhachHang()
        {
            InitializeComponent();
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            dsKhachHang = XuLyDuLieu.docBang("select * from KhachHang");
            dsKhachHangView = new DataView(dsKhachHang);
            dtgvKhachHang.DataSource = dsKhachHangView;
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
