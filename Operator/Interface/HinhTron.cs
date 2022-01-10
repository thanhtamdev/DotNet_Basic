using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class HinhTron: IHinh
    {
        private double r;

        public double dienTich()
        {
            return Math.PI * r * r;
        }

        public double chuVi()
        {
            return 2* Math.PI * r;
        }
    }
}
