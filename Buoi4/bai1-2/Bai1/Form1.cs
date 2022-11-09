using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        List<DichVu> dv = new List<DichVu>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc muốn thoát?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(check == DialogResult.OK)
                Application.Exit();
        }

        //hàm tính tiền
        public void TinhTien()
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng !!!");
            }
            else
            {
                decimal tongtien = 0;
                if (chbCaoVoi.Checked)
                    tongtien += dv[0].DonGia;
                if (chbTayTrang.Checked)
                    tongtien += dv[1].DonGia;
                if (chbChupHinhRang.Checked)
                    tongtien += dv[2].DonGia;
                tongtien += numericUpDown1.Value * dv[3].DonGia;

                txtTotal.Text = tongtien.ToString("##,#");
                AddItemListBox();
            }
        }

        //Thêm item trong List Box
        public void AddItemListBox()
        {
            string text = txtName.Text + "\t\t" + txtTotal.Text;
            listBox1.Items.Add(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream output = new FileStream("Data.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);
                foreach(string item in listBox1.Items)
                {
                    writer.WriteLine(item);
                }
                writer.Close();
                output.Close();
                MessageBox.Show("Save Success.");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream input = new FileStream("Data.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                listBox1.Items.Clear();
                string str;
                while((str = reader.ReadLine()) != null)
                {
                    listBox1.Items.Add(str);
                }

                input.Close();
                reader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loadClass();
            //loadform();

        }
        public void loadClass()
        {
            try
            {
                FileStream input = new FileStream("DonGia.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);

                string str;
                int i = 0;
                List<String> tendv = new List<string>()
                {
                    "Cạo vôi",
                    "Tẩy trắng",
                    "Chụp hình răng",
                    "Trám răng"
                };
                while ((str = reader.ReadLine()) != null)
                {
                    DichVu tam = new DichVu();
                    tam.TenDV = tendv[i];
                    tam.DonGia = int.Parse(str);

                    dv.Add(tam);

                    i++;
                }
                input.Close();
                reader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void loadform()
        {
            label3.Text = @"$" + dv[0].DonGia.ToString("##,#");
            label4.Text = @"$" + dv[1].DonGia.ToString("##,#");
            label5.Text = @"$" + dv[2].DonGia.ToString("##,#");
            label7.Text = @"$" + dv[3].DonGia.ToString("##,#") + "/cái";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            loadClass();
            loadform();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
