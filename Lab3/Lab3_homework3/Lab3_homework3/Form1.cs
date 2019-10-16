using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_homework3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = 0, month = 0, days_count = 0;
            bool leap = false;

            try
            {
                year = int.Parse(textBox1.Text);
                month = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Vuvedete korektni danni v poletata");
                textBox1.Clear();
                textBox2.Clear();
                return;
            }

            if (year < 1900 || (month < 1 && month > 12))
            {
                MessageBox.Show("Vuvedete korektni danni v poletata \n\"year:\" <<1900 - presen>> \n\"mounth:\" <<1 - 12>>");
            }
            else
            {
                leap = DateTime.IsLeapYear(year);
                days_count = DateTime.DaysInMonth(year, month);
                MessageBox.Show("The year " + year.ToString() + " is " + (leap ? "leap" : "normal") + ". " +
                    (System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)) + " has " + days_count.ToString() + " days!");
            }
        }
    }
}
