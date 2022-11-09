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

namespace Bai3_SecurityPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filename = "data.txt";

            try
            {
                FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(input);

                string str;

                while ((str = reader.ReadLine()) != null)
                {
                    //string[] list = str.Split(',');
                    listBox1.Items.Add(str);
                }
                input.Close();
                reader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //xóa
            if (e.KeyCode == Keys.Back)
            {
                char[] array;
                array = textBox1.Text.ToCharArray();
                textBox1.Text = "";
                for (int i = 0; i < array.Length - 1; i++)
                {
                    textBox1.Text += array[i].ToString();
                }

            }
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                textBox1.Text += "1";
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                textBox1.Text += "2";
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                textBox1.Text += "3";
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                textBox1.Text += "4";
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                textBox1.Text += "5";
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                textBox1.Text += "6";
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                textBox1.Text += "7";
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                textBox1.Text += "8";
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                textBox1.Text += "9";
            }
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                textBox1.Text += "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            if (value.Length != 4)
                return;
            switch (value)
            {
                case "1645":
                    {
                        string time = DateTime.Now.ToString("dd/MM/yyyy").Trim();

                        time += "\tTechnicians";
                        listBox1.Items.Add(time);
                        break;
                    }
                case "1689":
                    {
                        string time = DateTime.Now.ToString("dd/MM/yyyy").Trim();

                        time += "\tTechnicians";
                        listBox1.Items.Add(time);
                        break;
                    }
                case "8345":
                    {
                        string time = DateTime.Now.ToString("dd/MM/yyyy").Trim();

                        time += "\tCustodians";
                        listBox1.Items.Add(time);
                        break;
                    }
                case "9998":
                    {
                        string time = DateTime.Now.ToString("dd/MM/yyyy").Trim();

                        time += "\tScientist";
                        listBox1.Items.Add(time);
                        break;
                    }
                case "1006":
                case "1007":
                case "1008":
                    {
                        string time = DateTime.Now.ToString("dd/MM/yyyy").Trim();

                        time += "\tScientist";
                        listBox1.Items.Add(time);
                        break;
                    }



                default:
                    {
                        string time = DateTime.Now.ToString("dd/MM/yyyy").Trim();

                        time += "\tRetricted Access!";
                        listBox1.Items.Add(time);
                        break;
                    }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string filename = "data.txt";

            try
            {
                FileStream output = new FileStream(filename, FileMode.Create, FileAccess.Write);
                StreamWriter write = new StreamWriter(output);

                foreach (string item in listBox1.Items)
                {
                    write.WriteLine(item);
                }
                write.Close();
                output.Close();
                MessageBox.Show("Save Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length < 4)
            {
                //ErrorProvider a = new ErrorProvider();
                //a.SetError(textBox1, "Chưa đủ ký tự vui lòng nhập thêm");


                errorProvider1.SetError(textBox1, "Chưa đủ ký tự");
            }
            else if(textBox1.Text.Length > 4)
            {
                //ErrorProvider a = new ErrorProvider();
                //a.SetError(textBox1, "Tối đa 4 ký tự");
                errorProvider1.SetError(textBox1, "Tối đa 4 ký tự");
            }
            else
            {
                //ErrorProvider a = new ErrorProvider();
                //a.SetError(textBox1, "sflhsdjfh");
                errorProvider1.SetError(textBox1, null);

            }
        }

        
    }
}
