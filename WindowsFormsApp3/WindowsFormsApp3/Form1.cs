using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        double x, y;
        int num;
        bool znak = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }
        private void calculate()
        {
            double ost = 0;
            switch (num)
            {
                case 1:
                    y = x + double.Parse(textBox1.Text); 
                    textBox1.Text = y.ToString();
                    break;
                case 2:
                    y = x - double.Parse(textBox1.Text); 
                    textBox1.Text = y.ToString();
                    break;
                case 3:
                    y = x * double.Parse(textBox1.Text); 
                    textBox1.Text = y.ToString();
                    break;
                case 4:
                    y = x / double.Parse(textBox1.Text); 
                    textBox1.Text = y.ToString();
                    break;
                case 5:
                    y = x % double.Parse(textBox1.Text);
                    textBox1.Text = y.ToString();
                    break;
                case 6:
                    y = Math.Sin(x); 
                    textBox1.Text = y.ToString();
                    break;
                case 7:
                    y = Math.Cos(x); 
                    textBox1.Text = y.ToString();
                    break;
                default:
                    break;
            }
                 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Clear();
            num = 1;
            label1.Text = x.ToString() + "+";
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + ",";
            x = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + ",";
            textBox1.Clear();
            num = 2;
            label1.Text = x.ToString() + "-";
            znak = true;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Clear();
            num = 3;
            label1.Text = x.ToString() + "*";
            znak = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Clear();
            num = 4;
            label1.Text = x.ToString() + "/";
            znak = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int l = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for(int i = 0; i < l; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (znak)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Clear();
            num = 5;
            label1.Text = x.ToString() + "%";
            znak = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Clear();
            num = 6;
            label1.Text = x.ToString() + "Sin";
            znak = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Clear();
            num = 7;
            label1.Text = x.ToString() + "Cos";
            znak = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int l = textBox1.Text.Length;
            if (l > 1 || l< 1)
            {

            }
            else
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
