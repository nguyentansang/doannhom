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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dangnhap()
        {
            if (m.Text.Length == 0 && n.Text.Length == 0)
                MessageBox.Show("Bạn chưa đặng nhập");
            else
                if (this.m.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập tài khoản");
            else
                    if (this.n.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            else
                       if (this.m.Text == "giamdoc" && this.n.Text == "congty")
                MessageBox.Show("Bạn đã đăng nhập thành công");
            else
                if (this.m.Text == "bpql1" && this.n.Text == "congty")
                MessageBox.Show("Bạn đã đăng nhập thành công");
            else
                if (this.m.Text == "bpql2" && this.n.Text == "congty")
                MessageBox.Show("Bạn đã đăng nhập thành công");
            else
                if (this.m.Text == "bpql3" && this.n.Text == "congty")
                MessageBox.Show("Bạn đã đăng nhập thành công");
            else
                if (this.m.Text == "cn1" && this.n.Text == "congty")
                MessageBox.Show("Bạn đã đăng nhập thành công");
            else
                if (this.m.Text == "cn2" && this.n.Text == "congty")
                MessageBox.Show("Bạn đã đăng nhập thành công");
            else
                if (this.m.Text == "cn3" && this.n.Text == "congty")
                MessageBox.Show("Bạn đã đăng nhập thành công");
            else
                if (this.m.Text == "td1" && this.n.Text == "congty")
                MessageBox.Show("Bạn đã đăng nhập thành công");
            else
                if (this.m.Text == "td2" && this.n.Text == "congty")
                MessageBox.Show("Bạn đã đăng nhập thành công");
            else
                if (this.m.Text == "td3" && this.n.Text == "congty")
                MessageBox.Show("Bạn đã đăng nhập thành công");
            else
                MessageBox.Show("Bạn đã đăng nhập sai");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            m.Focus();
            n.Focus();
        }

        private void a_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            bophanquanli bpql = new bophanquanli();
            fDonHangChiNhanh cn=new fDonHangChiNhanh();
            tongdai td=new tongdai();
            if (this.m.Text == "giamdoc" && this.n.Text == "congty")
            {
                f.Show();
            }
            else
            {
                if (this.m.Text=="bpql1"&& this.n.Text=="congty"||this.m.Text=="bpql2"&&this.n.Text=="congty"||this.m.Text=="bpql3"&&this.n.Text=="congty")
                {
                    bpql.Show();
                }
               else
                {
                    if(this.m.Text == "cn1" && this.n.Text == "congty"|| this.m.Text == "cn2" && this.n.Text == "congty"|| this.m.Text == "cn3" && this.n.Text == "congty")
                    {
                        cn.Show();
                    }
                    else
                    {
                        if(this.m.Text == "td1" && this.n.Text == "congty"||this.m.Text == "td2" && this.n.Text == "congty"|| this.m.Text == "td3" && this.n.Text == "congty")
                        {
                            td.Show();
                        }
                    }
                }
            }
            dangnhap();
        }

        private void b_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
