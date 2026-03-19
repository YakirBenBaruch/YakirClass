using System;

namespace Yakir
{
    public class Line
    {
        private double a;
        private double b;

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
            this.b = p.y - a * p.x;
        }

        public Line(Point p1, Point p2)
        {
            this.a = (p2.y - p1.y) / (p2.x - p1.x);
            this.b = p1.y - this.a * p1.x;
        }

        public Line(Line line)
        {
            this.a = line.a;
            this.b = line.b;
        }
    }
}