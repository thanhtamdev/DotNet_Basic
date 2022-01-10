using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Programmer : Employee, IWage
    {
        private double luongLTV;
        private int soLoi;

        public double LuongLTV
        {
            get
            {
                return luongLTV;
            }

            set
            {
                luongLTV = value;
            }
        }

        public int SoLoi
        {
            get
            {
                return soLoi;
            }

            set
            {
                soLoi = value;
            }
        }

        public override void NhapTTNV()
        {
            Console.Write(" Nhap ma nhan vien: ");
            maNV = Console.ReadLine();
            Console.Write(" Nhap ho ten nhan vien: ");
            hoTen = Console.ReadLine();
            Console.Write(" Nhap luong cung: ");
            luongLTV = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Nhap so loi lap trinh: ");
            soLoi = Convert.ToInt32(Console.ReadLine());
        }

        public override void InTTNV()
        {
            Console.WriteLine("\n Thong tin luong cua nhan vien:");
            Console.WriteLine(" - Ma nhan vien: " + maNV);
            Console.WriteLine(" - Ho ten nhan vien: " + hoTen);
            Console.WriteLine(" - Luong: " + TinhLuong());
        }

        public double TinhLuong()
        {
            if (soLoi < 20)
            {
                luongLTV += luongLTV * 0.2;
            }

            return luongLTV;
        }
    }
}
