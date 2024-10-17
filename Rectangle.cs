using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_quiz_1
{
    public class Rectangle : Shape
    {
        private double length, width;

        public Rectangle(double length, double width) :
            base(length*width)
        {
            this.length = length;
            this.width = width;
        }

        public void DisplayRectangleArea()
        {
            Console.WriteLine($"Rectangle Area: {area}");
        }
    }
}
