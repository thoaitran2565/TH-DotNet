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

namespace Bai1
{
    public partial class frmXemKhoa : Form
    {
        public frmXemKhoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_SinhVienDataSet);

        }

        private void frmXemKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.qL_SinhVienDataSet.KHOA);

            textBox1.DataBindings.Add(new Binding("Text", maKhoaComboBox.DataSource, "TenKhoa"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string conn = global::Bai1.Properties.Settings.Default.QL_SinhVienConnectionString;
            //string str = string.Format("Select MaSo from SinhVien where MaKhoa = {0}", maKhoaComboBox.Text);
            //SqlDataAdapter da = new SqlDataAdapter(str, conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds);

            //dataGridView1.DataSource = ds.Tables[0];

            string conn = global::Bai1.Properties.Settings.Default.QL_SinhVienConnectionString;

            string str;
            str = string.Format("Select * From SinhVien where MaKhoa = '{0}'",maKhoaComboBox.Text);
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



        }
    }
}
