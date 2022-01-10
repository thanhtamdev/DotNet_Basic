using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    class Lop
    {
        private string maLop;
        private string tenLop;

        public string MaLop
        {
            get
            {
                return maLop;
            }

            set
            {
                maLop = value;
            }
        }

        public string TenLop
        {
            get
            {
                return tenLop;
            }

            set
            {
                tenLop = value;
            }
        }

        public Lop(string maLop, string tenLop)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
        }
    }
}
