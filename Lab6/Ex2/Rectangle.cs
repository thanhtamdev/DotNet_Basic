using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{
    class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle()
        {
            height = 0;
            width = 0;
        }

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double Height
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

        public double Width
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

        public override void Input()
        {
            do
            {
                Console.Write(" Height: ");
                height = Convert.ToDouble(Console.ReadLine());
            } while (height <= 0);

            do
            {
                Console.Write(" Width: ");
                width = Convert.ToDouble(Console.ReadLine());
            } while (width <= 0);
        }

        public override void Output()
        {
            Console.WriteLine(" Hinh chu nhat: Height = {0}, Width = {1}", height, width);
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
