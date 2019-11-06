using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String palindrom = textBox1.Text.ToUpper();
            if (palindrom.SequenceEqual(palindrom.Reverse()))
            {
                MessageBox.Show("The word is an palindrome !");
            }
            else
            {
                MessageBox.Show("The word isn't an palindrome !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(textBox1.Text);
            string message = "";
            foreach (byte b in asciiBytes)
            {
                message += " " + b;
            }
            MessageBox.Show(message);
        }
    }
}
