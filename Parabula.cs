using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            double y = this.a * x * x + this.b * x + this.c;
            return new Line(m, y);
        }

        public Point[] InterceptLine(Line line)
        {
            Point[] arr;
            Parabula p = new Parabula(this.a, this.b - line.GetA(), this.c - line.GetB());
            double n = line.GetA();
            double m = line.GetB();
            arr = p.Xintercept();
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i].Sety(this.GetY(arr[i].Getx()));
                }
            }
            return arr;
        }

        public Line PerpendicularFromPoint(Point p, double Xcoord)
        {
            Line masik = new Line();
            masik = this.Tangent(Xcoord).Perpendicular(p);
            return masik;
        }

        public Point[] InterceptParabola(Parabula par)
        {
            Point[] arr;
            Parabula parabula = new Parabula(this.a - par.GetA(), this.b - par.GetB(), this.c - par.GetC());
            arr = parabula.Xintercept();
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i].Sety(this.GetY(arr[i].Getx()));
                }
            }
            return arr;
        }

        public double ExtremeArea()
        {
            Point[] arr = this.Xintercept();

            if (arr == null || arr.Length < 2)
                return 0;

            Point p1 = arr[0];
            Point p2 = arr[1];
            Point p3 = this.Extreme();

            double area = Math.Abs(
                p1.Getx() * (p2.Gety() - p3.Gety()) +
                p2.Getx() * (p3.Gety() - p1.Gety()) +
                p3.Getx() * (p1.Gety() - p2.Gety())
            ) / 2.0;

            return area;
        }

        public double ExtremeArea(Line ln)
        {
            Point[] arr = this.InterceptLine(ln);

            if (arr == null || arr.Length < 2)
                return 0;

            Point p1 = arr[0];
            Point p2 = arr[1];
            Point p3 = this.Extreme();

            double area = Math.Abs(
                p1.Getx() * (p2.Gety() - p3.Gety()) +
                p2.Getx() * (p3.Gety() - p1.Gety()) +
                p3.Getx() * (p1.Gety() - p2.Gety())
            ) / 2.0;

            return area;
        }

        public double ExtremeAREA(Line ln)
        {
            Point[] arr = this.InterceptLine(ln);

            if (arr == null || arr.Length < 2)
                return 0;

            Point p1 = arr[0];
            Point p2 = arr[1];
            Point p3 = this.Extreme();

            double area = Math.Abs(
                p1.Getx() * (p2.Gety() - p3.Gety()) +
                p2.Getx() * (p3.Gety() - p1.Gety()) +
                p3.Getx() * (p1.Gety() - p2.Gety())
            ) / 2.0;

            return area;
        }

        public override string ToString()
        {
            return "Parabula: y = " + this.a + "x^2 + " + this.b + "x + " + this.c;
        }
        public static void UnitTest()
        {
            Parabula p1 = new Parabula(1, -3, 2);
            Console.WriteLine("---- Test 1: Create + Yintercept ----");
            Console.WriteLine("Y-intercept: " + p1.Yintercept());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---- Test 2: GetY ----");
            double yAt2 = p1.GetY(2);
            Console.WriteLine("Y at x=2: " + yAt2);
            Console.WriteLine();
            Console.WriteLine("---- Test 3: IsOnParabula ----");
            Point testPoint = new Point(1, 0);
            Console.WriteLine("Is point " + testPoint + " on the parabola? " + p1.IsOnParabula(testPoint));
            Console.WriteLine();
            Console.WriteLine("---- Test 4: Extreme ----");
            Point extremePoint = p1.Extreme();
            Console.WriteLine("Extreme point: " + extremePoint);
            Console.WriteLine();
            Console.WriteLine("---- Test 5: Tangent ----");
            Line tangentLine = p1.Tangent(7);
            Console.WriteLine("Tangent at x=7: " + tangentLine);
            Console.WriteLine("---- Test 6: Perpendicular From Point ----");
            Point testPoint2 = new Point(2, 3);
            Line perpendicularLine = p1.PerpendicularFromPoint(testPoint2, 2);
            Console.WriteLine("Perpendicular from point " + testPoint2 + " at x=2: " + perpendicularLine);
            Console.WriteLine("---- Test 7: InterceptParabola ----");

        }
    }
}
