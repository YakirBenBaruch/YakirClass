using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Parabula
    {
        private double a;
        private double b;
        private double c;

        public Parabula(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Parabula(double p , double k)
        {
            this.a = 1;
            this.b = -2 * p;
            this.c = p * p + k;
        }
    }
}
