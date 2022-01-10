using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class KHTraTheoDL : KhachHang
    {
        private int dungLuong;

        public KHTraTheoDL(string maKH, string hoTen, int dungLuong) : base(maKH, hoTen)
        {
            this.dungLuong = dungLuong;
        }

        public override int TinhCuoc()
        {
            return dungLuong * 200;
        }
    }
}
