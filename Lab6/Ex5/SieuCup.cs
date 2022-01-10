using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class SieuCup : ThiSinh
    {
        private double csdl;

        public double MyProperty
        {
            get
            {

                return csdl;
            }

            set
            {
                csdl = value;
            }
        }

        public override void NhapTTTS()
        {
            base.NhapTTTS();
            Console.Write(" Nhap diem bai thi CSDL: ");
            csdl = Convert.ToDouble(Console.ReadLine());
        }

        public override void InTTTS()
        {
            base.InTTTS();
            Console.WriteLine(" Diem bai thi CSDL: " + csdl);
            Console.WriteLine(" Tong diem: " + TinhTongDiem());
        }

        public override double TinhTongDiem()
        {
            return base.TinhTongDiem() + csdl;
        }
    }
}
