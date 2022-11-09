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
using System.Xml;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Thoát
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
                XmlDocument doc = new XmlDocument();
                XmlNode root;
                doc.Load(@"E:\Code-window-form\BT C#\TH-DotNet\Buoi4\bai3\Bai1\XMLDonGia.xml");
                root = doc.DocumentElement;

                XmlNodeList dongias = root.SelectNodes("dichvu");
                decimal total = 0;

                if (chbCaoVoi.Checked == true)
                    total += int.Parse(dongias[0].SelectSingleNode("dongia").InnerText);
                if(chbTayTrang.Checked == true)
                    total += int.Parse(dongias[1].SelectSingleNode("dongia").InnerText);
                if (chbChupHinhRang.Checked == true)
                    total += int.Parse(dongias[2].SelectSingleNode("dongia").InnerText);
                total += numericUpDown1.Value * int.Parse(dongias[3].SelectSingleNode("dongia").InnerText);

                txtTotal.Text =@"$" + total.ToString("##,#");
                AddItemListBox();
            }
        }

        //Thêm item trong List Box
        public void AddItemListBox()
        {
            string text = txtName.Text + "-" + txtTotal.Text;
            listBox1.Items.Add(text);
            txtName.Text = "";

            chbCaoVoi.Checked = false;
            chbTayTrang.Checked = false;
            chbChupHinhRang.Checked = false;
            numericUpDown1.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root;
            doc.Load(@"E:\Code-window-form\BT C#\TH-DotNet\Buoi4\bai3\Bai1\XMLHoaDon.xml");
            root = doc.DocumentElement;

            foreach(string item in listBox1.Items)
            {
                XmlNode node = doc.CreateElement("item");
                node.InnerText = item;
                root.AppendChild(node);
            }

            doc.Save(@"E:\Code-window-form\BT C#\TH-DotNet\Buoi4\bai3\Bai1\XMLHoaDon.xml");

            MessageBox.Show("Save Success.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root;
            doc.Load(@"E:\Code-window-form\BT C#\TH-DotNet\Buoi4\bai3\Bai1\XMLHoaDon.xml");
            root = doc.DocumentElement;

            XmlNodeList list = root.SelectNodes("item");
            listBox1.Items.Clear();
            foreach(XmlNode item in list)
            {
                listBox1.Items.Add(item.InnerText);
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

        public void loadform()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root;
            doc.Load(@"E:\Code-window-form\BT C#\TH-DotNet\Buoi4\bai3\Bai1\XMLDonGia.xml");
            root = doc.DocumentElement;
            XmlNodeList dongias = root.SelectNodes("dichvu");

            label3.Text = @"$" + int.Parse(dongias[0].SelectSingleNode("dongia").InnerText).ToString("##,#");
            label4.Text = @"$" + int.Parse(dongias[1].SelectSingleNode("dongia").InnerText).ToString("##,#");
            label5.Text = @"$" + int.Parse(dongias[2].SelectSingleNode("dongia").InnerText).ToString("##,#");
            label7.Text = @"$" + int.Parse(dongias[3].SelectSingleNode("dongia").InnerText).ToString("##,#") + "/cái";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            loadform();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
