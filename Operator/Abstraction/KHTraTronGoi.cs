using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class KHTraTronGoi : KhachHang
    {
        public KHTraTronGoi(string maKH, string hoTen):base(maKH, hoTen)
        {

        }
        public override int TinhCuoc()
        {
            return 300_000;
        }
    }
}
