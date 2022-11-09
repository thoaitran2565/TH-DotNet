using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.MdiParent = this;
            f.Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            frmKhoa f = new frmKhoa();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmMon f = new frmMon();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmNhapDiem f = new frmNhapDiem();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmXemDiem f = new frmXemDiem();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmXemKhoa f = new frmXemKhoa();
            f.MdiParent = this;
            f.Show();
        }
    }
}
