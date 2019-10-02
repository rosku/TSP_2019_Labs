using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Homework1R
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator MyCalculator = new Calculator();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MyCalculator.sended = (sender as Button).Text;
                double val1 = Double.Parse(textBox1.Text);
                double val2 = Double.Parse(textBox2.Text);
                textBox3.Text = MyCalculator.calculation(val1, val2).ToString();
            }
            catch
            {
                MessageBox.Show("Преди да натиснеш бутона, се увери, че данните са коректни!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MyCalculator.sended = (sender as Button).Text;
                double val1 = Double.Parse(textBox1.Text);
                double val2 = Double.Parse(textBox2.Text);
                textBox3.Text = MyCalculator.calculation(val1, val2).ToString();
            }
            catch
            {
                MessageBox.Show("Преди да натиснеш бутона, се увери, че данните са коректни!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MyCalculator.sended = (sender as Button).Text;
                double val1 = Double.Parse(textBox1.Text);
                double val2 = Double.Parse(textBox2.Text);
                textBox3.Text = MyCalculator.calculation(val1, val2).ToString();
            }
            catch
            {
                MessageBox.Show("Преди да натиснеш бутона, се увери, че данните са коректни!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MyCalculator.sended = (sender as Button).Text;
                double val1 = Double.Parse(textBox1.Text);
                double val2 = Double.Parse(textBox2.Text);
                textBox3.Text = MyCalculator.calculation(val1, val2).ToString();
            }
            catch
            {
                MessageBox.Show("Преди да натиснеш бутона, се увери, че данните са коректни!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
            try
            {
                MyCalculator.sended = comboBox1.Text;
                double val1 = Double.Parse(textBox1.Text);
                double val2 = Double.Parse(textBox2.Text);
                textBox3.Text = MyCalculator.calculation(val1, val2).ToString();
            }
            catch
            {
                MessageBox.Show("Преди да натиснеш бутона, се увери, че данните са коректни!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
            if(textBox1.Text.Length>0 && textBox2.Text.Length>0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
        }
    }
}
