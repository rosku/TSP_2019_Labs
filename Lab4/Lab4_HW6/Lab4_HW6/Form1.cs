using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_HW6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dobavki = { "1. becon", "2. chorizo", "3. pepperoni", "4. maslini", "5. gubi" };

            foreach (string top in dobavki)
            {
                this.checkedListBox1.Items.Add(top);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double money = 0;
            double count = 0;
            List<string> dobavki = new List<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                CheckState st = checkedListBox1.GetItemCheckState(i);
                if (st == CheckState.Checked)
                {
                    count++;
                    money++;
                    string qq = String.Format("{0}", (int.Parse(checkedListBox1.GetItemText(i)) + 1));
                    dobavki.Add(qq);
                }
            }

            int size = 0;
            if (radioButton1.Checked)
            {
                money += 9.25;
                size = 1;
            }

            if (radioButton2.Checked)
            {
                money += 11.50;
                size = 2;
            }

            if (radioButton3.Checked)
            {
                money += 13.75;
                size = 3;
            }

            if (checkBox1.Checked)
                money += 1.5;
            string strr = "";
            if (count > 0)
            {
                strr = String.Format("Vie poruchahte {0} blat {1} pizza {2} s {3} dobavki\n(",
                   radioButton4.Checked == true ? "tunuk" : "debel",
                   size == 1 ? "malka" : size == 2 ? "sredna" : "golqma",
                   checkBox1.Checked ? "S poveche kashkaval" : "bez dobavka kashkaval",
                   count);
                foreach (string top in dobavki)
                {
                    strr = String.Format("{0}{1} ", strr, top);
                }
                strr = String.Format("{0})", strr);
            }
            else
            {
                strr = String.Format("Vie poruchahte {0} blat {1} pizza {2} bez dobavki",
                       radioButton4.Checked == true ? "tunuk" : "debel",
                       size == 1 ? "malka" : size == 2 ? "sredna" : "golqma",
                       checkBox1.Checked ? "S poveche kashkaval" : "bez dobavka kashkaval");
            }
            strr = String.Format("{0}\nTotal Price is: {1}", strr, money);
            label4.Text = strr;
         
        }
    }
}
