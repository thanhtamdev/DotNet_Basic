using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Circle
    {
        private double radius;

        // constructor 
        public Circle()
        {
            radius = 1;
        }

        public Circle(int r)
        {
            radius = r;
        }

        // Set, Get radius
        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(int r)
        {
            radius = r;
        }

        public void InputRadius()
        {
            Console.Write(" Input radius: R = ");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            Console.WriteLine(" Perimeter: P = " + 2 * Math.PI * radius);
        }

        public void Area()
        {
            Console.WriteLine(" Area: S = " + Math.PI * radius * radius);
        }

        public void OutPutCircle()
        {
            Console.WriteLine(" Circle with radius: R = " + radius);
        }
    }
}
