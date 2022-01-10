using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Tester : Employee
    {
        private int luongTester;
        private double soGioOT;

        public int LuongTester
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
            Console.WriteLine(" Nhap thong tin cua tester: ");
            base.NhapTTNV();
            Console.Write(" Nhap luong cua tester: ");
            luongTester = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap so gio OT: ");
            soGioOT = Convert.ToDouble(Console.ReadLine());
        }

        public override void InTTNV()
        {
            base.InTTNV();
            Console.WriteLine(" - Luong: " + TinhLuong());
        }

        public override double TinhLuong()
        {
            return luongTester + soGioOT * 200_000;
        }
    }
}