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

        public override string ToString()
        {
            return "Rectangle:\n" + $"bottom-left point = ({bottomLeft.x}, {bottomLeft.y})\n" + $"top-right point = ({topRight.x}, {topRight.y})";
        }
    }
}