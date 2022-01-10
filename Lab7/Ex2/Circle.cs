using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Circle : IShape
    {
        private double radius;

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

        public double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
