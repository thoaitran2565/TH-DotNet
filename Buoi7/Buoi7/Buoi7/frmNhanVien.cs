using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7
{
    public partial class frmNhanVien : Form
    {
        SqlConnection conn;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadlisview();
        }
        void loadlisview()
        {
            //"Data source=thoai\sqlexpress;database=QLTHUVIEN;Integrated Security = True";
            string connString = @"Data source=thoai\sqlexpress;database=QLTHUVIEN;User id=sa;password=Thoai0912887543";
            conn = new SqlConnection(connString);

            string sqlstring = "select * from NHANVIEN";

            SqlDataAdapter da = new SqlDataAdapter(sqlstring, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ds.Tables[0].Rows[i]["HoTenNhanVien"].ToString();
                item.SubItems.Add(ds.Tables[0].Rows[i]["NgaySinh"].ToString());
                item.SubItems.Add(ds.Tables[0].Rows[i]["DienThoai"].ToString());
                item.SubItems.Add(ds.Tables[0].Rows[i]["DiaChi"].ToString());

                listView1.Items.Add(item);
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = listView1.SelectedItems.Count;
            if(count > 0)
            {
                //MessageBox.Show(count.ToString());
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!=""&&textBox3.Text!=""&&dateTimePicker1.Text!="")
            {
                errorProvider1.Clear();

                //thêm vào database
                string insertString = string.Format("insert into NHANVIEN values (N'{0}','{1}',N'{2}','{3}',{4})", textBox1.Text, dateTimePicker1.Text, textBox3.Text, textBox2.Text, 1);
                conn.Open();
                SqlCommand cm = new SqlCommand(insertString, conn);
                cm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Insert Success");

                //thêm vào listview
                ListViewItem item = new ListViewItem();
                item.Text = textBox1.Text;
                item.SubItems.Add(dateTimePicker1.Text);
                item.SubItems.Add(textBox2.Text);
                item.SubItems.Add(textBox3.Text);

                listView1.Items.Add(item);

                //xóa textbox
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                dateTimePicker1.Text = "";
            }
            else
            {
                if(textBox1.Text == "")
                {
                    errorProvider1.SetError(textBox1, "Vui lòng nhập trường này");
                }
                if (textBox2.Text == "")
                {
                    errorProvider1.SetError(textBox2, "Vui lòng nhập trường này");
                }
                if (textBox3.Text == "")
                {
                    errorProvider1.SetError(textBox3, "Vui lòng nhập trường này");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = listView1.SelectedItems.Count;
            if (count > 0)
            {
                //sửa trong database
                conn.Open();
                string sqlstring = "select * from NHANVIEN";

                SqlDataAdapter da = new SqlDataAdapter(sqlstring, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                int index = listView1.SelectedItems[0].Index;
                string manv = ds.Tables[0].Rows[index]["MaNhanVien"].ToString();

                string insertString = string.Format("update NHANVIEN set HoTenNhanVien = N'{0}',NgaySinh = '{1}', DiaChi = N'{2}',DienThoai = '{3}' where MaNhanVien = {4}",textBox1.Text,dateTimePicker1.Text,textBox3.Text,textBox2.Text,manv);
                SqlCommand cm = new SqlCommand(insertString, conn);
                cm.ExecuteNonQuery();

                conn.Close();


                //sửa listview
                ListViewItem item = new ListViewItem();
                item.Text = textBox1.Text;
                item.SubItems.Add(dateTimePicker1.Text);
                item.SubItems.Add(textBox2.Text);
                item.SubItems.Add(textBox3.Text);

                listView1.Items.RemoveAt(index);
                listView1.Items.Insert(index, item);



                MessageBox.Show("Update success");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn sửa!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = listView1.SelectedItems.Count;
            if (count > 0)
            {
                //xóa trong database
                conn.Open();
                string sqlstring = "select * from NHANVIEN";

                SqlDataAdapter da = new SqlDataAdapter(sqlstring, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                int index = listView1.SelectedItems[0].Index;
                string manv = ds.Tables[0].Rows[index]["MaNhanVien"].ToString();

                string insertString = string.Format("delete NHANVIEN where MaNhanVien = '{0}'",manv);
                SqlCommand cm = new SqlCommand(insertString, conn);
                cm.ExecuteNonQuery();

                conn.Close();


                //xóa listview
                listView1.Items.RemoveAt(index);

                //xóa textbox
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                dateTimePicker1.Text = "";

                MessageBox.Show("Delete success");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn xóa!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
