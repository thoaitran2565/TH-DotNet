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
    public partial class Form2 : Form
    {
        List<DichVu> dv = new List<DichVu>();

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        public void HienThi()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root;
            doc.Load(@"E:\Code-window-form\BT C#\TH-DotNet\Buoi4\bai3\Bai1\XMLDonGia.xml");
            root = doc.DocumentElement;

            XmlNodeList list = root.SelectNodes("dichvu");
            dgv.Rows.Clear();

            dgv.ColumnCount = 2;
            int sd = 0;
            foreach (XmlNode item in list)
            {
                dgv.Rows.Add();

                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("tendv").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("dongia").InnerText;
                sd++;
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTenDV.Text == "")
            {
                errorProvider1.SetError(txtTenDV, "Vui lòng nhập tên dịch vụ");
            }
          
            else
            {
                errorProvider1.SetError(txtTenDV, null);

                XmlDocument doc = new XmlDocument();
                XmlNode root;
                doc.Load(@"E:\Code-window-form\BT C#\TH-DotNet\Buoi4\bai3\Bai1\XMLDonGia.xml");
                root = doc.DocumentElement;

                XmlNode itemcansua = root.SelectSingleNode("dichvu[tendv='" + txtTenDV.Text.ToLower() + "']");
                if(itemcansua != null)
                {
                    XmlNode itemmoi = doc.CreateElement("dichvu");

                    XmlNode tendv = doc.CreateElement("tendv");
                    tendv.InnerText = txtTenDV.Text.ToLower();
                    itemmoi.AppendChild(tendv);

                    XmlNode dongia = doc.CreateElement("dongia");
                    dongia.InnerText = numericUpDown1.Value.ToString();
                    itemmoi.AppendChild(dongia);

                    root.ReplaceChild(itemmoi, itemcansua);
                    doc.Save(@"E:\Code-window-form\BT C#\TH-DotNet\Buoi4\bai3\Bai1\XMLDonGia.xml");

                    txtTenDV.Text = "";
                    numericUpDown1.Value = 0;
                    HienThi();
                }
                else
                {
                    errorProvider1.SetError(txtTenDV, "Dịch Vụ Không Tồn tại !!!");
                }





            }
        }
    }

}
