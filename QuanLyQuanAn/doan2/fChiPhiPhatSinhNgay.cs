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
    
    public partial class fChiPhiPhatSinhNgay : Form
    {
        DataTable dsChiPhi;
        public fChiPhiPhatSinhNgay()
        {
            InitializeComponent();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            DataRow cp = dsChiPhi.NewRow();
            dsChiPhi.Rows.Add(cp);
            cp["Ngay"] = tbNgay.Text;
            cp["Thang"] = tbThang.Text;
            cp["Nam"] = tbNam.Text;
            cp["ChiPhiPhatSinh"] = tbChiPhi.Text;
            XuLyDuLieu.ghiBang("ChiPhiPhatSinh", dsChiPhi);

            MessageBox.Show("Nhập Thành Công");
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fChiPhiPhatSinhNgay_Load(object sender, EventArgs e)
        {
            dsChiPhi = XuLyDuLieu.docBang("select * from ChiPhiPhatSinh");
        }
    }
}
