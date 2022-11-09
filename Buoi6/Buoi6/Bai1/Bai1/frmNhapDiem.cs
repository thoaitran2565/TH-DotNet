using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmNhapDiem : Form
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void ketQuaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ketQuaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_SinhVienDataSet);

        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.qL_SinhVienDataSet.KetQua);

        }
    }
}
