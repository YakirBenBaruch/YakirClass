using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point() : this(0, 0)
        {

        }

        public void Setx(int x)
        {
            this.x = x;
        }
        public double Getx()
        {
            return this.x;
        }

        public void Sety(int y)
        {
            this.y = y;
        }
        public double Gety()
        {
            return this.y;
        }

        public double Distance(Point P)
        {
            double dx2 = Math.Pow(this.x - P.Getx() , 2);
            double dy2 = Math.Pow(this.y - P.Gety(), 2);
            return Math.Sqrt(dx2 + dy2);
        }

        public Point Midpoint(Point P)
        {
            double midX = (this.x + P.x) / 2;
            double midY = (this.y + P.y) / 2;

            return new Point(midX, midY);
        }

        public override string ToString()
        {
            return $"({this.x} , {this.y})";
        }

        public static void UnitTest()
        {
            Point p1 = new Point(3, 4);
            Console.WriteLine(p1);
            p1.Setx(5);
            Console.WriteLine(p1.Getx());
            p1.Sety(6);
            Console.WriteLine(p1.Gety());
            Console.WriteLine(p1);
            Console.WriteLine("========================");
            Point p2 = new Point();
            Console.WriteLine(p2);
            double distance = p1.Distance(p2);
            Console.WriteLine(distance);


        }
    }
}
