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
        private const string V = "3.14";
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
            textBox1.Text = V;
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
                textBox1.Text = "";
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

        private void Arithmetic_Operators(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textBox1.Text);
            textBox1.Text = "";
           // textBox1.Text = System.Convert.ToString(results) + " " + operation; 
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Mod":
                    textBox1.Text = (results % Double.Parse(textBox1.Text)).ToString();
                    break; 
                case "Exp":
                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = (results);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);  
            ilog = Math.Log10( ilog );
            textBox1.Text = System.Convert.ToString( ilog );
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(textBox1.Text);
            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);
        }
    }
}
