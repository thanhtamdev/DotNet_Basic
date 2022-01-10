using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Rectangle : Shape
    {
        public Rectangle() { }

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public new int Height
        {
            get{
                return height;
            }

            set
            {
                height = value;
            }
        }

        public int Area()
        {
            return height * width;
        }
    }
}
