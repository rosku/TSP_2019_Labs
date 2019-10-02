using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Homework2R
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int val1 = Int32.Parse(textBox1.Text);
                if(val1%2==0)
                {
                    label1.Text = "Числото е четно!";
                }
                else
                {
                    label1.Text = "Числото е нечетно!";
                }
            }
            catch
            {
                MessageBox.Show("Моля въведете коректни стойности!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label1.Text = "Моля въведете коректни стойности!";
                textBox1.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Това е приложение което показва дали даденото число е четно или не!", "ЧЕТНО/НЕЧЕТНО", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Напускане на приложението?", "Демо", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
