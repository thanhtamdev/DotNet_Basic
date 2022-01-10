using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    interface IBook
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int GiaSach { get; set; }
        public int GiaGiam { get; set; }
        public int GiaBan();
    }
}
