using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7
{
    public partial class frmDMNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        public frmDMNhanVien()
        {
            InitializeComponent();
        }
        void HienthiNhanvien()
        {
            DataTable dt = nv.LayDanhSachSinhVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                listView1.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        void setNull()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }
        void setButton(bool val)
        {
            button4.Enabled = val;
            button3.Enabled = val;
            button1.Enabled = val;
            button2.Enabled = val;
            button6.Enabled = !val;
            button5.Enabled = !val;
        }
        void HienthiBangcap()
        {
            DataTable dt = nv.LayBangcap();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "TenBangCap";
            comboBox1.ValueMember = "MaBangCap";
        }


        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            HienthiNhanvien();
            HienthiBangcap();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                //Chuyen sang kieu dateTime
                dateTimePicker1.Value = DateTime.Parse(listView1.SelectedItems[0].SubItems[2].Text);
                textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
                //Tìm vị trí của Tên bằng cấp trong Combobox
                comboBox1.SelectedIndex = comboBox1.FindString(listView1.SelectedItems[0].SubItems[5].Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
