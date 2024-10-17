using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_quiz_1
{
    public class Circle : Shape
    {
        private double Radius;

        public Circle(double radius) :
            base(radius * radius * double.Pi)
        {
            this.Radius = radius;
        }

        public void DisplayCircleInfo()
        {
            Console.WriteLine("Circle Area: " + area);
        }
    }
}
