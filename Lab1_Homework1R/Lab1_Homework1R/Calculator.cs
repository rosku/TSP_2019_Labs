using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Homework1R
{
    class Calculator
    {

        public string sended { get; set; }
        public double calculation(double val1, double val2)
        {

            if (sended.Equals("+"))
            {
                return val1 + val2;
            }
            else if (sended.Equals("-"))
            {
                return val1 - val2;
            }
            else if (sended.Equals("×"))
            {
                return val1 * val2;
            }
            else
            {
                return val1 / val2;
            }
        }

    }
}
