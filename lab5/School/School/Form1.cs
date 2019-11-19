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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stipnedii form = new Stipnedii();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, @"\P{IsCyrillic}") && !Regex.IsMatch(textBox2.Text, @"\P{IsCyrillic}") &&
                !Regex.IsMatch(textBox3.Text, @"\P{IsCyrillic}") && !String.IsNullOrEmpty(textBox1.Text) &&
                !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text))
            {
                if(char.IsUpper(textBox1.Text[0]) && char.IsUpper(textBox2.Text[0]) && char.IsUpper(textBox3.Text[0])){
                    if (Regex.IsMatch(textBox4.Text, @"^\d{10}$"))
                    {
                        if (!Regex.IsMatch(textBox5.Text, @"\P{IsCyrillic}") && !String.IsNullOrEmpty(textBox5.Text))
                        {
                            form.Show();
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "Моля въведете адрес на кирилица ! ";
                        }
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Въведете правилно ЕГН ! ";
                    }
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Въведете правилно вашите имена ! ";
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }
    }
}
