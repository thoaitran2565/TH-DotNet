using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Add(txtSonguyen.Text);
            txtSonguyen.Text = "";
            txtSonguyen.Focus();

        }

        private void txtSonguyen_TextChanged(object sender, EventArgs e)
        {
            Control ctrSonguyen = (Control)sender;
            if (ctrSonguyen.Text.Length > 0)
                if (!char.IsDigit(ctrSonguyen.Text[ctrSonguyen.Text.Length - 1]))
                    this.errSonguyen.SetError(ctrSonguyen, "Vui lòng nhập số nguyên");
                else
                    this.errSonguyen.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult kt = MessageBox.Show("Bạn muốn thoát?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            //if (kt != DialogResult.OK)
            //    e.Cancel = true;
        }

        private void btTang2_Click(object sender, EventArgs e)
        {
            int sl = lstKetqua.Items.Count;
            for (int i = 0; i < sl; i++)
            {
                int tam = int.Parse(lstKetqua.Items[i].ToString()) + 2;

                lstKetqua.Items.RemoveAt(i);
                lstKetqua.Items.Insert(i, tam.ToString());

            }
        }

        private void btChonchandau_Click(object sender, EventArgs e)
        {
            int sl = lstKetqua.Items.Count;
            for (int i = 0; i < sl; i++)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 0)
                {
                    string s = lstKetqua.Items[i].ToString();
                    lstKetqua.SelectedItem = s;
                    break;
                }

            }
        }

        private void btLecuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count; //Số mục trong lst
            for (int i = n - 1; i >= 0; i--)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 1)
                {
                    string s = lstKetqua.Items[i].ToString();//Lay gia tri muc gia tri lẻ
                    lstKetqua.SelectedItem = s;//Chon muc co gia tri le
                    break; //Thuc hien duoc so le dau (tu duoi len) thi ket thuc vong lap
                }
            }

        }

        private void btXoaphantudangchon_Click(object sender, EventArgs e)
        {
            
            int n = lstKetqua.SelectedItems.Count; //Số mục trong lst
            for (int i = n - 1; i >= 0; i--)
                lstKetqua.Items.Remove(lstKetqua.SelectedItems[i].ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstKetqua.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btXoaphantudau_Click(object sender, EventArgs e)
        {
            if(lstKetqua.Items.Count == 0)
              return;
            lstKetqua.Items.RemoveAt(0);
        }

        private void btXoaphantucuoi_Click(object sender, EventArgs e)
        {
            if (lstKetqua.Items.Count == 0)
                return;
            int sl = lstKetqua.Items.Count;
            lstKetqua.Items.RemoveAt(sl-1);
        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
