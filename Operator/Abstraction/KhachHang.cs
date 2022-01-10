using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class KhachHang
    {
        protected string maKH;
        protected string hoTen;

        public string HoTen
        {
            get
            {
                return hoTen;
            }
        }

        public KhachHang(string maKH, string hoTen)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
        }

        // Phương thức tính cước
        public abstract int TinhCuoc();
    }
}
