using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_3
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == "")
            {
                errorProvider1.SetError(txtHoten, "Vui lòng nhập họ tên");
            }
            else
            {
                errorProvider1.Clear();

                ListViewItem list = new ListViewItem();
                list.Text = txtHoten.Text;

                list.SubItems.Add(dtpNgaysinh.Text);
                list.SubItems.Add(txtDiachi.Text);
                list.SubItems.Add(txtDienthoai.Text);

                lsvNhanVien.Items.Add(list);

                //xóa text trên các textbox
                txtHoten.Text = "";
                txtDiachi.Text = "";
                txtDienthoai.Text = "";
                dtpNgaysinh.Text = "";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count != 0)
                foreach (ListViewItem item in lsvNhanVien.SelectedItems)
                {
                    lsvNhanVien.Items.Remove(item);
                }
            else
                MessageBox.Show("Vui lòng chọn dòng muốn xóa");
            //errorProvider1.SetError(button4, "sfkjhsjdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count != 0)
            {
                int vtri = lsvNhanVien.Items.IndexOf(lsvNhanVien.SelectedItems[0]);
                lsvNhanVien.Items.RemoveAt(vtri);

                ListViewItem list = new ListViewItem();
                list.Text = txtHoten.Text;

                list.SubItems.Add(dtpNgaysinh.Text);
                list.SubItems.Add(txtDiachi.Text);
                list.SubItems.Add(txtDienthoai.Text);

                lsvNhanVien.Items.Insert(vtri, list);

            }
               
            else
                MessageBox.Show("Vui lòng chọn dòng muốn sửa");
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem list = lsvNhanVien.SelectedItems[0];
                txtHoten.Text = list.SubItems[0].Text;
                dtpNgaysinh.Text = list.SubItems[1].Text;
                txtDiachi.Text = list.SubItems[2].Text;
                txtDienthoai.Text = list.SubItems[3].Text;
            }
               
        }
    }
}
