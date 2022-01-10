using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Chuyen : ThiSinh
    {
        private double tiengAnh;

        public double TiengAnh
        {
            get
            {
                return tiengAnh;
            }

            set
            {
                tiengAnh = value;
            }
        }

        public override void NhapTTTS()
        {
            base.NhapTTTS();
            Console.Write(" Nhap diem bai thi tieng anh: ");
            tiengAnh = Convert.ToDouble(Console.ReadLine());
        }

        public override void InTTTS()
        {
            base.InTTTS();
            Console.WriteLine(" Diem bai thi tieng anh: " + tiengAnh);
            Console.WriteLine(" Tong diem: " + TinhTongDiem());
        }

        public override double TinhTongDiem()
        {
            if (tiengAnh < 7)
            {
                return base.TinhTongDiem();
            }
            else if (tiengAnh <= 8)
            {
                return base.TinhTongDiem() + 1;
            }
            else
            {
                return base.TinhTongDiem() + 2;
            }
        }
    }
}
