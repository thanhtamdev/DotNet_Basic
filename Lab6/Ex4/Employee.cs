using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Employee
    {
        protected string maNV;
        protected string hoTen;

        public Employee()
        {
            maNV = "";
            hoTen = "";
        }

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

        public virtual void NhapTTNV()
        {
            Console.Write(" Nhap ma nhan vien: ");
            maNV = Console.ReadLine();
            Console.Write(" Nhap ho ten nhan vien: ");
            hoTen = Console.ReadLine();
        }

        public virtual void InTTNV()
        {
            Console.WriteLine(" Thong tin luong cua nhan vien:");
            Console.WriteLine(" - Ma nhan vien: " + maNV);
            Console.WriteLine(" - Ho ten nhan vien: " + hoTen);
        }

        public virtual double TinhLuong()
        {
            return 0;
        }
    }
}
