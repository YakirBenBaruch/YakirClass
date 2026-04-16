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

        public double GetA() { return this.a; }
        public double GetB() { return this.b; }
        public double GetC() { return this.c; }
        public void SetA(double a) { this.a = a; }
        public void SetB(double b) { this.b = b; }
        public void SetC(double c) { this.c = c; }

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
            double Delta = this.b * this.b - 4 * this.a * this.c;

            if (Delta < 0)
            {
                return null;
            }

            else if (Delta == 0)
            {
                arr = new Point[1];
                double x = -this.b / (2 * this.a);
                arr[0] = new Point(x, 0);
                return arr;
            }

            else
            {
                arr = new Point[2];
                double x1 = (-this.b + Math.Sqrt(Delta)) / (2 * this.a);
                double x2 = (-this.b - Math.Sqrt(Delta)) / (2 * this.a);
                arr[0] = new Point(x1, 0);
                arr[1] = new Point(x2, 0);
                return arr;
            }
        }

        public double GetY(double x)
        {
            double Y = this.a * x * x + this.b * x + this.c;
            return Y;
        }

        public bool IsOnParabula(Point p)
        {
            bool b = false;
            double checkY = this.a * p.Getx() * p.Getx() + this.b * p.Getx() + this.c;
            if (checkY == p.Gety())
            {
                b = true;
            }
            return b;
        }

        public Point Extreme()
        {
            Point PE = new Point();
            PE.Setx(-this.b / (2 * this.a));
            PE.Sety(this.a * PE.Getx() * PE.Getx() + this.b * PE.Getx() + this.c);
            return PE;
        }

        public Line Tangent(double x)
        {
            double m = 2 * this.a * x + this.b;
        }
        
        public static void UnitTest()
        {
            Parabula p1 = new Parabula(1, -3, 2);
            Console.WriteLine("---- Test 1: Create + Yintercept ----");
            Console.WriteLine("Y-intercept: " + p1.Yintercept());
            Console.WriteLine();
            Console.WriteLine("---- Test 2: Xintercept ----");
            Console.WriteLine();
            Console.WriteLine("---- Test 3: GetY ----");
            double yAt2 = p1.GetY(2);
            Console.WriteLine("Y at x=2: " + yAt2);
            Console.WriteLine();
            Console.WriteLine("---- Test 4: IsOnParabula ----");
            Point testPoint = new Point(1, 0);
            Console.WriteLine("Is point " + testPoint + " on the parabola? " + p1.IsOnParabula(testPoint));
            Console.WriteLine();
            Console.WriteLine("---- Test 5: Extreme ----");
            Point extremePoint = p1.Extreme();
            Console.WriteLine("Extreme point: " + extremePoint);
        }
    }
}
