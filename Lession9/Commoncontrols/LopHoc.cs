using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commoncontrols
{
    class LopHoc
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

        public LopHoc(string maLop, string tenLop)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
        }
    }
}
