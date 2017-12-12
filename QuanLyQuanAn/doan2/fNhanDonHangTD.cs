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
    public partial class fNhanDonHangTD : Form
    {
        DataTable dsDonHang;
        public fNhanDonHangTD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsDonHang = XuLyDuLieu.docBang("select * from DonHang where Loai like '%3%' ");
            dtgvNhanDH.DataSource = dsDonHang;
        }
    }
}
