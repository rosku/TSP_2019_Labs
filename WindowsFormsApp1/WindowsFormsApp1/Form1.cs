using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        public void Calc(int action)
        {
            double val1 = 0, val2 = 0;
            try
            {
                val1 = Double.Parse(textBox1.Text);
                val2 = Double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }

            switch (action)
            {
                case 0:
                    textBox3.Text = Calculator.AddNumbers(val1, val2).ToString();
                    break;
                case 1:
                    textBox3.Text = Calculator.SubNumbers(val1, val2).ToString();
                    break;
                case 2:
                    textBox3.Text = Calculator.MulNumbers(val1, val2).ToString();
                    break;
                case 3:
                    textBox3.Text = Calculator.DevNumbers(val1, val2).ToString();
                    break;
            }
        }

        Calculator Calculator = new Calculator();

        private void button1_Click(object sender, EventArgs e)
        {
            Calc(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calc(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calc(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calc(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(textBox1.Text);
            double val2 = double.Parse(textBox2.Text);

            switch (comboBox1.Text)
            {
                case "Add":
                    textBox3.Text = Calculator.AddNumbers(val1, val2).ToString();
                    break;
                case "Subtract":
                    textBox3.Text = Calculator.SubNumbers(val1, val2).ToString();
                    break;
                case "Multiply":
                    textBox3.Text = Calculator.MulNumbers(val1, val2).ToString();
                    break;
                case "Devide":
                    textBox3.Text = Calculator.DevNumbers(val1, val2).ToString();
                    break;
            }
        }
    }
}
