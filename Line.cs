using System;

namespace Yakir
{
    public class Line
    {
        private double a;
        private double b;

        public int GetA() { return (int)a; }
        public int GetB() { return (int)b; }

        public void SetA(double a) { this.a = a; }
        public void SetB(double b) { this.b = b; }

        public Line(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public Line()
        {
            this.a = 1;
            this.b = 0;
        }

        public Line(double a, Point p)
        {
            this.a = a;
            this.b = p.Gety() - a * p.Getx();
        }

        public Line(Point p1, Point p2)
        {
            this.a = (p2.Gety() - p1.Gety()) / (p2.Getx() - p1.Getx());
            this.b = p1.Gety() - this.a * p1.Getx();
        }

        public Line(Line line) 
        {
            this.a = line.a;
            this.b = line.b;
        }

        public Point Yintercept()
        {
            return new Point(0, this.b);
        }

        public Point Xintercept()
        {
            return new Point(-this.b / this.a, 0);
        }

        public double GetY(double x)
        {
            return this.a * x + this.b;
        }

        public bool IsOnLine(Point p)
        {
            if (p.Gety() == GetY(p.Getx()))
            {
                return true;
            }
            return false;
        }

        public int LineStatus(Line line)
        {
            if (this.a == line.a && this.b == line.b)
            {
                return -1;
            }
            else if (this.a == line.a)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public Point LineIntercept(Line line)
        {
            if (this.LineStatus(line) == 1)
            {
                double NewX = (line.b - this.b) / (this.a - line.a);
                double NewY = this.GetY(NewX);

                return new Point(NewX, NewY);
            }

            else if (this.LineStatus(line) == -1)
            {
                return null;
            }

            else
            {
                return null;
            }
        }

        public Line Perpendicular(Point p)
        {
            double newA = -1 / this.a;
            return new Line(newA, p);
        }

        public double Distance(Point p)
        {
            Line L2 = this.Perpendicular(p);
            Point P2 = this.LineIntercept(L2);
            double distance = p.Distance(P2);

            return distance;
        }

        public double AreaWithX(Line line)
        {
            if (this.a == line.a)
                return 0;

            Point p1 = this.Xintercept();
            Point p2 = line.Xintercept();
            Point p3 = this.LineIntercept(line);

            if (p1 == null || p2 == null || p3 == null)
                return 0;

            double baseLength = Math.Abs(p1.Getx() - p2.Getx());
            double height = Math.Abs(p3.Gety());

            return (baseLength * height) / 2;
        }

        public override string ToString()
        {
            if (b >= 0)
            {

                return "f(x) = " + a + "x + " + b;
            }

            else
            {
                return "f(x) = " + a + "x - " + Math.Abs(b);
            }
                
        }
    }
}