using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1HWTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Поздравявам ви с поредният си проект на C#");
        }

        private void ChangeFromColor(object sender, EventArgs e)
        {
            if(sender is Button)
            { this.BackColor = (sender as Button).BackColor;
                this.Text = sender.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            //this.BackColor=Color.FromArgb(204,0,0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            //this.BackColor=Color.FromArgb(0,102,204);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;//this.BackColor=Color.FromArgb(0,0,0);
            label1.Text = "Click one of the buttons bellow \n to see the magic working...";
            label1.Font = new Font("Arial", 14);
            label1.ForeColor = Color.White;
        }
    }
}
