using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class HinhChuNhat: IHinh
    {
        private int chieuDai;
        private int chieuRong;
        public double dienTich()
        {
            return chieuDai * chieuRong;
        }

        public double chuVi()
        {
            return (chieuDai + chieuRong) * 2;
        }
    }
}
