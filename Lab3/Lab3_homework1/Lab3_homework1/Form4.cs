using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_homework1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, D, x1, x2;
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);

                D = (b * b) - (4 * a * c);

                x1 = (-b - (Math.Sqrt(D))) / 2;
                x2 = (-b + (Math.Sqrt(D))) / 2;

                textBox4.Text = D.ToString();
                textBox5.Text = x1.ToString();
                textBox6.Text = x2.ToString();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
        }
    }
}
