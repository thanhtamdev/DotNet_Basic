using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Tester : Employee, IWage
    {
        private double luongTester;
        private double soGioOT;

        public double LuongTester
        {
            get
            {
                return luongTester;
            }

            set
            {
                luongTester = value;
            }
        }

        public double SoGioOT
        {
            get
            {
                return soGioOT;
            }

            set
            {
                soGioOT = value;
            }
        }

        public override void NhapTTNV()
        {
            Console.Write(" Nhap ma nhan vien: ");
            maNV = Console.ReadLine();
            Console.Write(" Nhap ho ten nhan vien: ");
            hoTen = Console.ReadLine();
            Console.Write(" Nhap luong cung: ");
            luongTester = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Nhap so gio OT: ");
            soGioOT = Convert.ToDouble(Console.ReadLine());
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
            return luongTester + soGioOT * 200000;

        }
    }
}
