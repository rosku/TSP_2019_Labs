﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_homework6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox1.Text) <= 100)
            {
             Form2 fr2 = new Form2(Int32.Parse(textBox1.Text));
                this.Hide();
            fr2.Show();
            }
           

            
        }
    }
}
