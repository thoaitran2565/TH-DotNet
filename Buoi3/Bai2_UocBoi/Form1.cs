using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_UocBoi
{
    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }
        public static int UCLN(int a, int b)
        {
            if (a == 0 || b == 0)
                return a + b;
            while (a != b)
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            return a;
        }
        public static int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }
        private void Nhập_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);

            if (radioUCLN.Checked == true)
            {
                txtKetQua.Text = UCLN(a, b).ToString();
            }
            else if (radioBCNN.Checked == true)
                txtKetQua.Text = BCNN(a, b).ToString();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetQua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoát khong", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
