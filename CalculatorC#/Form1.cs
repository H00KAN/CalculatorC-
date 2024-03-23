using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorC_
{
    public partial class Form1 : Form
    {
        double results = 0;
        String operation = "";
        bool enter_value = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 307;
            textBox1.Width = 266;
        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void стандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 307;
            textBox1.Width = 266;   
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 588;
            textBox1.Width = 548;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "0";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
    }
}
