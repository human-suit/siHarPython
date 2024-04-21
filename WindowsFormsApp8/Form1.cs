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

namespace WindowsFormsApp8
{

    public partial class Form1 : Form
    {
        int n, m, i, j;

        private void button1_Click(object sender, EventArgs e)
        {

            int rowNumber = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowNumber].Cells["ID"].Value = rowNumber;
            dataGridView1.Rows[rowNumber].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[rowNumber].Cells[2].Value = textBox2.Text ;
            dataGridView1.Rows[rowNumber].Cells["Tel"].Value = textBox3.Text;
            string fileName =rowNumber + " "+ textBox1.Text +" "+ textBox2.Text+ " " + textBox3.Text +"\r\n";
            textBox5.Text += fileName;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                dataGridView1.Rows.RemoveAt(cell.RowIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("data.txt");
            n = Convert.ToInt32(f.ReadLine());
            m = Convert.ToInt32(f.ReadLine());
            for (i = 0; i < n - 1; i++)
            {
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells[1].Value = f.ReadLine();
            }
            f.Close();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("data.txt");
            int rowNumber = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowNumber].Cells[1].Value = f.ReadLine();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|* .txt";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox5.Text, Encoding.GetEncoding(1251));
            }
            textBox1.Clear();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox5.Clear();
                openFileDialog1.Filter = "Text Files (*.txt) |*.txt";
                string fileName = openFileDialog1.FileName;
                textBox5.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Id");
            dataGridView1.Columns.Add("Fa", "Фамилия");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("Tel", "Телефон");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
