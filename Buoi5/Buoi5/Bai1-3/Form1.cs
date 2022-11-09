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
    public partial class Form1 : Form
    {
        DataTable tbOrder = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            tbOrder.Columns.Add("FoodName");
            tbOrder.Columns.Add("Quanlity");

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = tbOrder.Columns["FoodName"];
            tbOrder.PrimaryKey = PrimaryKeyColumns;

            dataGridView1.DataSource = tbOrder;

            dataGridView1.Columns[0].FillWeight = 2000;
            dataGridView1.Columns[1].FillWeight = 2000;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DataRow r = tbOrder.Rows.Find(button.Text);
            if (r==null)
            {
                DataRow t = tbOrder.NewRow();
                t["FoodName"] = button.Text;
                t["Quanlity"] = 1;
                tbOrder.Rows.Add(t);
            }
            else
            {
                r["Quanlity"] = int.Parse(r["Quanlity"].ToString()) +1; 
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            //{
            //    string r = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
            //    DataRow row = tbOrder.Rows.Find(r);
            //    tbOrder.Rows.Remove(row);
            //}

            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                DataRow r = tbOrder.Rows.Find(item.Cells[0].Value);
                if(r!=null)
                    tbOrder.Rows.Remove(r);
            }

        }
    }
}
