using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_HW1R
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator calc = new Calculator();

        private void Error()
        {
            MessageBox.Show("Incorrect data!", "Error");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private double Calculate(double d1, double d2, object sender)
        {
            string s = (sender as Button).Text;

            switch (s)
            {
                case "+":
                    return calc.Add(d1, d2);
                case "-":
                    return calc.Sub(d1, d2);
                case "×":
                    return calc.Mul(d1, d2);
                case "÷":
                    return calc.Div(d1, d2);
                default:
                    return 0;
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            double ch1, ch2, result;
            try
            {
                ch1 = Double.Parse(textBox1.Text);
                ch2 = Double.Parse(textBox2.Text);
                result = Calculate(ch1, ch2, sender);
                textBox3.Text = result.ToString();
            }
            catch
            {
                Error();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ch1, ch2, result;
            try
            {
                ch1 = Double.Parse(textBox1.Text);
                ch2 = Double.Parse(textBox2.Text);
                result = Calculate(ch1, ch2, sender);
                textBox3.Text = result.ToString();

            }
            catch
            {
                Error();
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            double ch1, ch2, result;
            try
            {
                ch1 = Double.Parse(textBox1.Text);
                ch2 = Double.Parse(textBox2.Text);
                result = Calculate(ch1, ch2, sender);
                textBox3.Text = result.ToString();
            }
            catch
            {
                Error();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double ch1, ch2, result;
            try
            {
                ch1 = Double.Parse(textBox1.Text);
                ch2 = Double.Parse(textBox2.Text);
                if (ch2 == 0) { Error(); } 
                else
                {
                    result = Calculate(ch1, ch2, sender);
                    textBox3.Text = result.ToString();
                }
            }
            catch
            {
                Error();
            }
        }
    }

    internal class Calculator
    {
        internal double Add(double d1, double d2)
        {
            throw new NotImplementedException();
        }

        internal double Div(double d1, double d2)
        {
            throw new NotImplementedException();
        }

        internal double Mul(double d1, double d2)
        {
            throw new NotImplementedException();
        }

        internal double Sub(double d1, double d2)
        {
            throw new NotImplementedException();
        }
    }
}
