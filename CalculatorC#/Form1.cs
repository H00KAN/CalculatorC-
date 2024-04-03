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

        private void button36_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(textBox1.Text);
            qSinh = Math.Sinh(qSinh);
            textBox1.Text = System.Convert.ToString(qSinh);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(textBox1.Text);
            qSin = Math.Sin(qSin);
            textBox1.Text = System.Convert.ToString(qSin);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(textBox1.Text);
            qCosh = Math.Cosh(qCosh);
            textBox1.Text = System.Convert.ToString(qCosh);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double qCos = Double.Parse(textBox1.Text);
            qCos = Math.Cos(qCos);
            textBox1.Text = System.Convert.ToString(qCos);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(textBox1.Text);
            qTanh = Math.Tanh(qTanh);
            textBox1.Text = System.Convert.ToString(qTanh);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(textBox1.Text);
            qTan = Math.Tan(qTan);
            textBox1.Text = System.Convert.ToString(qTan);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 2);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 /  Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txtMultiply.Text);
            for (int i = 1; i < 13; i ++)
            {
                istMultiply.Items.Add(i + " x " + a + " = " + a * i);
            }
        }

        private void умножениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 864;
            textBox1.Width = 513;
            istMultiply.Focus(); 
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            istMultiply.Items.Clear();
            txtMultiply.Clear();
        }
    }
}
