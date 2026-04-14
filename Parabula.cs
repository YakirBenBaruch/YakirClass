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

        public Parabula(double p, double k)
        {
            this.a = 1;
            this.b = -2 * p;
            this.c = p * p + k;
        }

        public Point Yintercept()
        {
            return new Point(0, this.c);
        }

        public Point[] Xintercept()
        {
            Point[] arr;
            double Dalta = this.b * this.b - 4 * this.a * this.c;

            if (Dalta < 0)
            {
                return null;
            }

            else if (Dalta == 0)
            {
                arr = new Point[1];
                double x = -this.b / (2 * this.a);
                arr[0] = new Point(x, 0);
                return arr;
            }

            else
            {
                arr = new Point[2];
                double x1 = (-this.b + Math.Sqrt(Dalta)) / (2 * this.a);
                double x2 = (-this.b - Math.Sqrt(Dalta)) / (2 * this.a);
                arr[0] = new Point(x1, 0);
                arr[1] = new Point(x2, 0);
                return arr;
            }
        }

        public static void UnitTest()
        {

        }
    }
}
