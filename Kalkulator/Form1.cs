using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        char c;
        public int i = 0;
        public double a;
        public double b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            if (i == 0)
            {
                richTextBox1.Text = richTextBox1.Text + ",";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "";
            }
            i++;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                c = '/';
                a = Convert.ToDouble(richTextBox1.Text);
                label1.Text = Convert.ToString(a) + c;
                i = 0;
            }
            catch (Exception)
            {

            }

            richTextBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                c = '*';
                a = Convert.ToDouble(richTextBox1.Text);
                label1.Text = Convert.ToString(a) + c;
                i = 0;
            }
            catch (Exception)
            {

            }

            richTextBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                c = '-';
                a = Convert.ToDouble(richTextBox1.Text);
                label1.Text = Convert.ToString(a) + c;
                i = 0;
            }
            catch (Exception)
            {
                
            }



            richTextBox1.Text = "";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                c = '+';
                a = Convert.ToDouble(richTextBox1.Text);
                label1.Text = Convert.ToString(a) + c;
                i = 0;
            }
            catch (Exception)
            {

            }


            richTextBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            i = 0;
            label1.Text = null;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(richTextBox1.Text);
                switch (c)
                {
                    case '+':
                        richTextBox1.Text = Convert.ToString(a + b);
                        break;
                    case '-':
                        richTextBox1.Text = Convert.ToString(a - b);
                        break;
                    case '*':
                        richTextBox1.Text = Convert.ToString(a * b);
                        break;
                    case '/':
                        richTextBox1.Text = Convert.ToString(a / b);
                        break;
                }
                 richTextBox1.Text = Convert.ToString(Math.Round(Convert.ToDouble(richTextBox1.Text),4));
                label1.Text = Convert.ToString(a) + c + Convert.ToString(b) + " = " + richTextBox1.Text;
            }
            catch (Exception)
            {

            }
            richTextBox1.Text = "";


        }

        private void инфоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form form3 = new Form3();
            form3.Show();
            this.Hide();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
            }
            catch (Exception) { }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToString(Math.Sin(Convert.ToDouble(richTextBox1.Text)));
            richTextBox1.Text = Convert.ToString(Math.Round(Convert.ToDouble(richTextBox1.Text), 4));
            label1.Text = richTextBox1.Text;
            richTextBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToString(Math.Cos(Convert.ToDouble(richTextBox1.Text)));
            richTextBox1.Text = Convert.ToString(Math.Round(Convert.ToDouble(richTextBox1.Text), 4));
            label1.Text = richTextBox1.Text;
            richTextBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToString(Math.Tan(Convert.ToDouble(richTextBox1.Text)));
            richTextBox1.Text = Convert.ToString(Math.Round(Convert.ToDouble(richTextBox1.Text), 4));
            label1.Text = richTextBox1.Text;
            richTextBox1.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Convert.ToString(Math.Cos(Convert.ToDouble(richTextBox1.Text))/Math.Sin(Convert.ToDouble(richTextBox1.Text)));
            richTextBox1.Text = Convert.ToString(Math.Round(Convert.ToDouble(richTextBox1.Text), 4));
            label1.Text = richTextBox1.Text;
            richTextBox1.Text = "";
        }

        private void редакторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 red = new Form4();
            red.Show();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void задачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 zadachi = new Form3();
            zadachi.Show();
        }
    }
}
