using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Programmer : Employee
    {
        private int luongLTV;
        private int soLoi;

        public int LuongLTV
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
            Console.WriteLine(" Nhap thong tin cua programmer:");
            base.NhapTTNV();
            Console.Write(" Nhap luong cua lap trinh vien: ");
            luongLTV = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap so loi lap trinh: ");
            soLoi = Convert.ToInt32(Console.ReadLine());
        }

        public override void InTTNV()
        {
            base.InTTNV();
            Console.WriteLine(" Luong: " + TinhLuong());

        }

        public override double TinhLuong()
        {
            if (soLoi < 20)
            {
                luongLTV += luongLTV * 10 / 100;
            }

            return luongLTV;
        }
    }
}
