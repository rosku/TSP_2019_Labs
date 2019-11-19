using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuiz
{
    class Class1
    {
        private static readonly Random rnd;
        public int p1 { get; set; }
        public int p2 { get; set; }
        public int m1 { get; set; }
        public int m2 { get; set; }
        public int mult1 { get; set; }
        public int mult2 { get; set; }
        public double d1 { get; set; }
        public double d2 { get; set; }

        public void Generate(int pp1,int pp2,int mm1,int mm2,int mu1,int mu2, double dd1, double dd2)
        {
            p1 = pp1;
            p2 = pp2;
            m1 = mm1;
            m2 = mm2;
            mult1 = mu1;
            mult2 = mu2;
            d1 = dd1;
            d2 = dd2;
        }
    }
}
