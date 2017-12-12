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
    public partial class fDoanhThuTong : Form
    {
        DataTable dsChiPhi;
        public fDoanhThuTong()
        {
            InitializeComponent();
        }

        private void fDoanhThuTong_Load(object sender, EventArgs e)
        {
            dsChiPhi = XuLyDuLieu.docBang("select * from ChiPhiPhatSinh");
            dtgvChiPhi.DataSource = dsChiPhi;
        }
    }
}
