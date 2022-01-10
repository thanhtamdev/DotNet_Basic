using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }

        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        public int TuSo
        {
            get
            {
                return tuSo;
            }
            set
            {
                tuSo = value;
            }
        }

        public int MauSo
        {
            get
            {
                return mauSo;
            }
            set
            {
                mauSo = value;
            }
        }

        public void NhapPS()
        {
            Console.Write(" Nhap tu so: ");
            tuSo = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write(" Nhap mau so (khac 0): ");
                mauSo = Convert.ToInt32(Console.ReadLine());
            } while (mauSo == 0);
        }

        public void XuatPS()
        {
            Console.Write(" " + tuSo + "/" + mauSo);
        }

        public static PhanSo operator +(PhanSo p1, PhanSo p2)
        {
            PhanSo p = new PhanSo();

            if (p1.mauSo != 0 && p2.mauSo != 0)
            {
                p.tuSo = p1.tuSo * p2.mauSo + p1.mauSo * p2.tuSo;
                p.mauSo = p1.mauSo * p2.mauSo;
            }
            else
            {
                Console.WriteLine(" Error.");
            }

            return p;
        }        
    }
}
