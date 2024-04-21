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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Clear();
                openFileDialog1.Filter = "Text Files (*.txt) |*.txt";
                string fileName = openFileDialog1.FileName;
                textBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|* .txt";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text, Encoding.GetEncoding(1251));
            }
            textBox1.Clear();
        }
    }
}
