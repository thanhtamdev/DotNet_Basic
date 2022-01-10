using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    abstract class Employee
    {
        protected string maNV;
        protected string hoTen;

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public abstract void NhapTTNV();

        public abstract void InTTNV();
    }
}
