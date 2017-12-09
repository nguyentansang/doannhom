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
    public partial class fDanhSachMonAn : Form
    {
        DataTable dsMonAn;

        public fDanhSachMonAn()
        {
            InitializeComponent();
        }

        private void btThoatDanhSachMonAn_Click(object sender, EventArgs e)
        {
            fDanhSachMonAn f = new fDanhSachMonAn();
            f.Close();
        }

        private void fDanhSachMonAn_Load(object sender, EventArgs e)
        {
            dsMonAn = XuLyDuLieu.docBang("select *from MonAn");
            dtgvMonAn.DataSource = dsMonAn;
        }

        private void dtgvMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
