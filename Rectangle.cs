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
        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.bottomLeft = new Point(bottomLeft);
            this.topRight = new Point(topRight);
        }
    }
}