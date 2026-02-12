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

        public void Getx(int x)
        {
            this.x = x;
        }
        public double Setx()
        {
            return this.x;
        }

        public void Gety(int y)
        {
            this.y = y;
        }
        public double Sety()
        {
            return this.y;
        }

        public override string ToString()
        {
            return $"({this.x} , {this.y})";
        }

        public static void UnitTest()
        {
            Point p1 = new Point(3, 4);
            Console.WriteLine(p1);
            p1.Getx(5);
            Console.WriteLine(p1.Setx());
            p1.Gety(6);
            Console.WriteLine(p1.Sety());
            Console.WriteLine(p1);
        }
    }
}
