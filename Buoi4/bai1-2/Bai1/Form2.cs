using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form2 : Form
    {
        List<DichVu> dv = new List<DichVu>();

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream input = new FileStream("DonGia.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                
                string str;
                int i = 0;
                List<String> tendv = new List<string>()
                {
                    "Cạo vôi",
                    "Tẩy trắng",
                    "Chụp hình răng",
                    "Trám răng"
                };
                while ((str = reader.ReadLine()) != null)
                {
                    DichVu tam = new DichVu();
                    tam.TenDV = tendv[i];
                    tam.DonGia = int.Parse(str);

                    dv.Add(tam);

                    i++;
                }
                input.Close();
                reader.Close();
                comboBox1.DataSource = dv;
                comboBox1.DisplayMember = "TenDV";

                textBox1.DataBindings.Add(new Binding("Text", dv, "DonGia"));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DichVu name = comboBox1.SelectedValue as DichVu;
            DichVu item =  dv.Where(c => c.TenDV == name.TenDV).FirstOrDefault();
            item.DonGia = int.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream output = new FileStream("DonGia.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);

                foreach (DichVu item in dv)
                {
                    writer.WriteLine(item.DonGia);
                }
                writer.Close();
                output.Close();
                MessageBox.Show("Save Success.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }

}
