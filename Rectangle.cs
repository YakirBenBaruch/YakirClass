using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class Rectangle
    {
        private Point bottomLeft;
        private Point topRight;

        public Rectangle(Point bottomLeft, Point topRight)
        {
            this.bottomLeft = new Point(bottomLeft);
            this.topRight = new Point(topRight);
        }

        public Rectangle(Point bottomLeft, double width, double height)
        {
            this.bottomLeft = new Point(bottomLeft);
            this.topRight = new Point(bottomLeft.x + width, bottomLeft.y + height);
        }

        private double Width()
        {
            return topRight.x - bottomLeft.x;
        }

        private double Height()
        {
            return topRight.y - bottomLeft.y;
        }

        public double GetArea()
        {
            return Width() * Height();
        }

        public double GetPerimeter()
        {
            return 2 * (Width() + Height());
        }

        public void Move(double deltaX, double deltaY)
        {
            bottomLeft.x += deltaX;
            bottomLeft.y += deltaY;

            topRight.x += deltaX;
            topRight.y += deltaY;
        }

        public bool Pointsln(Point p)
        {
            if (p.Getx() >= bottomLeft.Getx() && p.Getx() <= topRight.Getx() && p.Gety() >= bottomLeft.Gety() && p.Gety() <= topRight.Gety())
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            return "Rectangle:\n" + $"bottom-left point = ({bottomLeft.Getx()}, {bottomLeft.Gety()})\n" + $"top-right point = ({topRight.Getx()}, {topRight.y})";
        }

        public static void UnitTest()
        {
            Rectangle rect = new Rectangle(new Point(0, 0), new Point(4, 3));
            Console.WriteLine(rect);
            Console.WriteLine("Area: " + rect.GetArea());
            Console.WriteLine("Perimeter: " + rect.GetPerimeter());

            rect.Move(1, 1);
            Console.WriteLine("After moving by (1, 1):");
            Console.WriteLine(rect);

            Point p1 = new Point(2, 2);
            Point p2 = new Point(5, 5);
            Console.WriteLine($"Does the rectangle contain point {p1}? {rect.Pointsln(p1)}");
            Console.WriteLine($"Does the rectangle contain point {p2}? {rect.Pointsln(p2)}");
        }
    }
}