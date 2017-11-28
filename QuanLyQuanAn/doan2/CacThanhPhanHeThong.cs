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
    public partial class CacThanhPhanHeThong : Form
    {
        public CacThanhPhanHeThong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bophanquanli bpql = new bophanquanli();
            bpql.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chinhanh cn = new chinhanh();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
