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
            richTextBox1.Text = richTextBox1.Text + ",";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            c = '/';
            a = Convert.ToDouble(richTextBox1.Text);
            label1.Text = Convert.ToString(a) + c;
            


            richTextBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            c = '*';
            a = Convert.ToDouble(richTextBox1.Text);
            label1.Text = Convert.ToString(a) + c;



            richTextBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            c = '-';
            a = Convert.ToDouble(richTextBox1.Text);
            label1.Text = Convert.ToString(a) + c;



            richTextBox1.Text = "";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            c = '+';
            a = Convert.ToDouble(richTextBox1.Text);
            label1.Text = Convert.ToString(a) + c;



            richTextBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
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
            label1.Text = Convert.ToString(a) + c + Convert.ToString(b) + " = " + richTextBox1.Text;
            richTextBox1.Text = "";


        }

        private void инфоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
        }
    }
}
