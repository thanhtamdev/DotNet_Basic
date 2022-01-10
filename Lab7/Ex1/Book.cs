using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Book : IBook
    {
        private string maSach;
        private string tenSach;
        private int giaSach;
        private int giaGiam;

        public string MaSach
        {
            get
            {
                return maSach;
            }

            set
            {
                maSach = value;
            }
        }

        public string TenSach
        {
            get
            {
                return tenSach;
            }

            set
            {
                tenSach = value;
            }
        }

        public int GiaSach
        {
            get
            {
                return giaSach;
            }

            set
            {
                giaSach = value;
            }

        }

        public int GiaGiam
        {
            get
            {
                return giaGiam;
            }

            set
            {
                giaGiam = value;
            }
        }

        public int GiaBan()
        {
            return giaSach - giaGiam;
        }
    }
}
