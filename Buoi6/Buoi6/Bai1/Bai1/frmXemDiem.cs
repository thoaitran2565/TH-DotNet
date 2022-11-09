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
    public partial class frmXemDiem : Form
    {
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_SinhVienDataSet);

        }

        private void sinhVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_SinhVienDataSet);

        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.qL_SinhVienDataSet.KHOA);
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qL_SinhVienDataSet.SinhVien);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = global::Bai1.Properties.Settings.Default.QL_SinhVienConnectionString;

            string str;
            str = string.Format("Select TenMH, Diem From KetQua,Mon where [KetQua].MaMH = [Mon].MaMH AND MaSo = {0}", maSoComboBox.Text);
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



        }
    }
}
