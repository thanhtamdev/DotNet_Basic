using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Ball
    {
        private int kichThuoc;
        private Color color;
        private int soLanNemBong;

        public Ball()
        {
            kichThuoc = 1;
            color = new Color();
            soLanNemBong = 0;
        }

        public Ball(int kichThuoc, Color color, int soLanNemBong)
        {
            this.kichThuoc = kichThuoc;
            this.color = color;
            this.soLanNemBong = soLanNemBong;
        }

        public int KichThuoc
        {
            get
            {
                return kichThuoc;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(" Kich thuoc khong hop le.");
                }
                else
                {
                    kichThuoc = value;
                }
            }
        }

        public int SoLanNemBong
        {
            get
            {
                return soLanNemBong;
            }

            set
            {
                soLanNemBong = value;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                bool check = value.Red < 0 || value.Red > 255 || value.Green < 0 || value.Green > 255
                    || value.Blue < 0 || value.Blue > 255 || value.Alpha < 0 || value.Alpha > 255;

                if (check)
                {
                    Console.WriteLine(" Mau khong hop le.");
                }
                else
                {
                    color = value;
                }
            }
        }

        public int Pop()
        {
            kichThuoc = 0;

            return kichThuoc;
        }

        public int Throw()
        {
            if (kichThuoc != 0)
            {
                soLanNemBong += 1;
            }

            return soLanNemBong;
        }

        public void Input()
        {
            Console.Write(" Nhap kich thuoc cua trai bong: ");
            kichThuoc = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap mau sac cua trai bong: ");
            color.Red = Convert.ToInt32(Console.ReadLine());
            color.Green = Convert.ToInt32(Console.ReadLine());
            color.Blue = Convert.ToInt32(Console.ReadLine());
            color.Alpha = Convert.ToInt32(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine(" Kich thuoc bong: " + kichThuoc);
            Console.WriteLine(" Mau sac(RGBA): ({0}, {1}, {2}, {3}) ", color.Red, color.Green, color.Blue, color.Alpha);
        }
    }
}
