using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kalkulator
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog(this) == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(file.FileName);
            }
            
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "txt files (*.txt)|*.txt";
            if (file.ShowDialog(this) == DialogResult.OK)
            {
                Stream filestr = file.OpenFile();
                StreamWriter sw = new StreamWriter(filestr);
                sw.Write(richTextBox1.Text);
                sw.Close();
                filestr.Close();
            }

        }
    }
}
