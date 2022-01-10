using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Triangle : Shape
    {
        public Triangle() { }

        public Triangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public new int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public int Base
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public double Area()
        {
            return Convert.ToDouble(Base * Height) / 2;
        }
    }
}
