using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_CacPhepToanCoBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int Tong = n + m;
            txtKetqua.Text = Tong.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int Hieu = n - m;
            txtKetqua.Text = Hieu.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int Tich = n * m;
            txtKetqua.Text = Tich.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int Thuong = n / m;
            txtKetqua.Text = Thuong.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtSon.Text = "";
            txtSom.Text = "";
            txtKetqua.Text = "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
