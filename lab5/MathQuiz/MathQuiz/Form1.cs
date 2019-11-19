using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int counter = 20;
        Random rnd = new Random();
        Class1 numbers = new Class1();
       
        private void button1_Click(object sender, EventArgs e)
        {
            int p1 = rnd.Next(10, 20);
            int p2 = rnd.Next(10, 20);
            int m1 = rnd.Next(10, 20);
            int m2 = rnd.Next(10, 20);
            int mult1 = rnd.Next(10, 20);
            int mult2 = rnd.Next(10, 20);
            double d1 = rnd.Next(10, 20);
            double d2 = rnd.Next(10, 20);
            numbers.Generate(p1,p2,m1,m2,mult1,mult2,d1,d2);
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
            label6.Text = counter.ToString() + " seconds";

            plus1.Text = (numbers.p1.ToString());
            plus2.Text = (numbers.p2.ToString());
            minus1.Text = (numbers.m1.ToString());
            minus2.Text = (numbers.m2.ToString());
            multiply1.Text = (numbers.mult1.ToString());
            multiply2.Text = (numbers.mult2.ToString());
            divide1.Text = (numbers.d1.ToString());
            divide2.Text = (numbers.d2.ToString());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                try
                {
                    int sumed = Int32.Parse(sum.Value.ToString());
                    int diff = Int32.Parse(difference.Value.ToString());
                    int mult = Int32.Parse(multiply.Value.ToString());
                    double div = Double.Parse(division.Value.ToString());
                    if ((sumed == numbers.p1 + numbers.p2) && (diff == numbers.m1 - numbers.m2)
                        && (mult == numbers.mult1 * numbers.mult2) && (div == Math.Round((numbers.d1 / numbers.d2),2)))
                    {
                        MessageBox.Show("You answered correct ! ");
                    }
                    else
                    {
                        MessageBox.Show("You answered wrong !");
                    }
                }
                catch
                {
                    MessageBox.Show("Something went wrong!");
                }
                label6.BackColor = Form1.DefaultBackColor;
                counter = 20;
            }
            
            label6.Text = counter.ToString() + " seconds";
            if (counter == 5) { label6.BackColor = Color.Purple; }
        }
    }
}
