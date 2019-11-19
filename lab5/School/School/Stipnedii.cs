using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Stipnedii : Form
    {
        public Stipnedii()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^[0-9]\d{0,9}(\.\d{1,1})?%?$"); 
            Match txt1 = r.Match(textBox1.Text);
            Match txt2 = r.Match(textBox2.Text);
            Match txt3 = r.Match(textBox3.Text);
            if (txt1.Success && txt3.Success && txt2.Success )
            {
                MessageBox.Show("succes");
            }
            else
            {
                MessageBox.Show("Моля въведете правилни данни");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text) && !String.IsNullOrWhiteSpace(textBox2.Text) &&
               !String.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox4.Text = ((Double.Parse(textBox1.Text) + Double.Parse(textBox2.Text)) - Double.Parse(textBox3.Text)).ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
