using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Circle
    {
        private double banKinh;

        public double BanKinh
        {
            get
            {
                return banKinh;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(" Ban kinh khong hop le!");
                }
                else
                {
                    banKinh = value;
                }
            }
        }
    }
}
