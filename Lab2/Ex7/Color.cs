using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color()
        {
            red = 255;
            green = 255;
            blue = 255;
            alpha = 255;
        }

        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(Color color)
        {
            red = color.red;
            green = color.green;
            blue = color.blue;
            alpha = color.alpha;
        }

        public int Red
        {
            get
            {
                return red;
            }
            set
            {
                if (value < 0 || value > 255)
                {
                    Console.WriteLine(" Gia tri khong hop le.");
                }
                else
                {
                    red = value;
                }
            }
        }

        public int Green
        {
            get
            {
                return green;
            }
            set
            {
                if (value < 0 || value > 255)
                {
                    Console.WriteLine(" Gia tri khong hop le.");
                }
                else
                {
                    green = value;
                }
            }
        }

        public int Blue
        {
            get
            {
                return blue;
            }
            set
            {
                if (value < 0 || value > 255)
                {
                    Console.WriteLine(" Gia tri khong hop le.");
                }
                else
                {
                    blue = value;
                }
            }
        }

        public int Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                if (value < 0 || value > 255)
                {
                    Console.WriteLine(" Gia tri khong hop le.");
                }
                else
                {
                    alpha = value;
                }
            }
        }

        //public void Enter()
        //{
        //    red = Convert.ToInt32(Console.ReadLine());
        //    green = Convert.ToInt32(Console.ReadLine());
        //    blue = Convert.ToInt32(Console.ReadLine());
        //    alpha = Convert.ToInt32(Console.ReadLine());
        //}

        public int Grayscale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}
