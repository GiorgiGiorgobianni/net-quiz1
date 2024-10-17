using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_quiz_1
{
    public class Shape
    {
        protected double area;

        public Shape(double initialArea)
        {
            area = initialArea;
        }

        public void DisplayArea()
        {
            Console.WriteLine("Area: " + area);
        }
    }
}
