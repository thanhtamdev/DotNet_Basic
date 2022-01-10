using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{
    class Circle : Shape
    {
        private double radius;

        public Circle()
        {
            radius = 0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public override void Input()
        {
            do
            {
                Console.Write(" Radius: ");
                radius = Convert.ToDouble(Console.ReadLine());
            } while (radius <= 0);
        }

        public override void Output()
        {
            Console.WriteLine(" Hinh tron: Radius = " + radius);
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
