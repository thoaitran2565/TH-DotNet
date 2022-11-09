using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox2.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedItems.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i].ToString());
            }
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox2.Items)
            {
                listBox1.Items.Add(item);
            }
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedItems.Count;
            for (int i = 0; i < n; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
            }

            for (int i = n-1; i >= 0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = listBox2.SelectedItems.Count;
            for (int i = 0; i < n; i++)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[i]);
            }
        }
    }
}
