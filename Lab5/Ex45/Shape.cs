using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Shape
    {
        protected int height;
        protected int width;

        public Shape()
        {
            height = 0;
            width = 0;
        }

        public Shape(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public int Height
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

        public int Width
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
    }
}
