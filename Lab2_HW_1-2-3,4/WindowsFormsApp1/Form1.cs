using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);

                double D = Math.Sqrt((b * b) - (4 * a * c));

                double x1 = (b * (-1) + D) / (2 * a);
                double x2 = (b * (-1) - D) / (2 * a);

                label4.Text = String.Format("x1 = {0}", x1);
                label5.Text = String.Format("x2 = {0}", x2);
            }
            catch (Exception)
            {
                ;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            try
            {
                double a = double.Parse(textBox4.Text);
                double b = double.Parse(textBox5.Text);
                double c = double.Parse(textBox6.Text);

                double D = Math.Sqrt((b * b) - (4 * a * c));

                double x1 = (b * (-1) + D) / (2 * a);
                double x2 = (b * (-1) - D) / (2 * a);

                label6.Text = String.Format("x1 = {0}", x1);
                label7.Text = String.Format("x2 = {0}", x2);
            }
            catch (Exception)
            {
                ;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox4.Text);
                double b = double.Parse(textBox5.Text);
                double c = double.Parse(textBox6.Text);

                double D = Math.Sqrt((b * b) - (4 * a * c));

                double x1 = (b * (-1) + D) / (2 * a);
                double x2 = (b * (-1) - D) / (2 * a);

                label6.Text = String.Format("x1 = {0}", x1);
                label7.Text = String.Format("x2 = {0}", x2);
            }
            catch (Exception)
            {
                ;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox4.Text);
                double b = double.Parse(textBox5.Text);
                double c = double.Parse(textBox6.Text);

                double D = Math.Sqrt((b * b) - (4 * a * c));

                double x1 = (b * (-1) + D) / (2 * a);
                double x2 = (b * (-1) - D) / (2 * a);

                label6.Text = String.Format("x1 = {0}", x1);
                label7.Text = String.Format("x2 = {0}", x2);
            }
            catch (Exception)
            {
                ;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Celsius")
                {
                    double c = double.Parse(textBox7.Text);
                    textBox8.Text = String.Format("{0}", c * 1.8 + 32);
                    label15.Text = "degrees in F";
                }
                else if (comboBox1.Text == "Farrenheit")
                {
                    double f = double.Parse(textBox7.Text);
                    textBox8.Text = String.Format("{0}", (f - 32.0) * (5.0 / 9.0));
                    label15.Text = "degrees in C";
                }
            }
            catch (Exception)
            {
            }
        }

        private void Conv()
        {
            try
            {
                    double[,] massive = new double[4, 4]
                        {
                            {1, 0.3333, 1.1989, 0.0001893},
                            {3, 1,  3.5966, 0.0005682},
                            {0.8341, 0.278, 1,  0.0001579},
                            {1760, 1760, 6330, 1}
                        };
                double c = 0, r = 0;
                int x, y;
                x = comboBox2.SelectedIndex;
                y = comboBox3.SelectedIndex;
                c = double.Parse(textBox9.Text);
                r = Math.Round((c * massive[x, y]), 5);
                textBox10.Text = r.ToString();
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Celsius")
                {
                    double c = double.Parse(textBox7.Text);
                    textBox8.Text = String.Format("{0}", c * 1.8 + 32);
                    label15.Text = "degrees in F";
                }
                else if (comboBox1.Text == "Farrenheit")
                {
                    double f = double.Parse(textBox7.Text);
                    textBox8.Text = String.Format("{0}", (f - 32.0) * (5.0 / 9.0));
                    label15.Text = "degrees in C";
                }
            }
            catch (Exception)
            {
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conv();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conv();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox9.Text = null;
            textBox10.Text = null;
        }
    }
}
