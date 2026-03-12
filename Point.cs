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

        public Point(Point P) : this(P.x, P.y)
        {
            this.x = P.x;
            this.y = P.y;
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

        public double gradient(Point P)
        {
            int gradient = 0;
            int dx = (int)(P.x - this.x);
            int dy = (int)(P.y - this.y);

            gradient = dy / dx;
            return gradient;
        }

       public static Point FarthestfromOrigin(Point[] points)
        {
            Point farthest = points[0];
            for (int i = 1; i <= points.Length - 1; i++)
            {
                if (points[i].Distance(new Point(0, 0)) > farthest.Distance(new Point(0, 0)))
                {
                    farthest = points[i];
                }
            }
            return farthest;
        }

        public static int[] arrmidpoint(Point[] points)
        {
            Point[] midpoints = new Point[points.Length];
            for (int i = 0; i < points.Length - 1; i++)
            {
                midpoints[i] = points[i].Midpoint(new Point(0, 0));
            }

            for (int i = 0; i < midpoints.Length; i++)
            {
                Console.WriteLine(midpoints[i]);
                return new int[] { (int)midpoints[i].x, (int)midpoints[i].y };
            }

            return null;
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
            Point midpoint = p1.Midpoint(p2);
            Console.WriteLine(midpoint);

            Console.WriteLine("========================");

            double gradient = p1.gradient(p2);
            Console.WriteLine(gradient);
            Point[] points = { p1, p2, new Point(10, 10) };
            Point farthest = Point.FarthestfromOrigin(points);
            Console.WriteLine(farthest);

            Console.WriteLine("========================");
            
            int[] midpoints = Point.arrmidpoint(points);
            Console.WriteLine($"Midpoints: ({midpoints[0]}, {midpoints[1]})");

        }
    }
}
