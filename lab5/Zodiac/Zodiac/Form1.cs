using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zodiac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = Int32.Parse(dateTimePicker1.Value.Day.ToString());
            int month = Int32.Parse(dateTimePicker1.Value.Month.ToString());
            int[] fromDate = { 21, 20, 21, 21, 22, 22, 23, 23, 22, 23, 22, 22 };
            string[] signs = { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn" };
            if (day < fromDate[month - 1])
            {
                Zodiac.Items.Add(signs[month - 1]);
            }else
                Zodiac.Items.Add(signs[month]);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Zodiac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
