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
    public partial class frmMon : Form
    {
        public frmMon()
        {
            InitializeComponent();
        }

        private void monBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_SinhVienDataSet);

        }

        private void frmMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.qL_SinhVienDataSet.Mon);

        }
    }
}
