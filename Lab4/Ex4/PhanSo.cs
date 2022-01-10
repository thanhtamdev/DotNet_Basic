using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class PhanSo
    {
        private double tuSo;
        private double mauSo;

        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }

        public PhanSo(double tuSo, double mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        public double TuSo
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

        public double MauSo
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
            tuSo = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Nhap mau so: ");
            mauSo = Convert.ToDouble(Console.ReadLine());
        }

        public void XuatPS()
        {
            Console.WriteLine(" " + tuSo + "/" + mauSo);
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

        public static PhanSo operator -(PhanSo p1, PhanSo p2)
        {
            PhanSo p = new PhanSo();

            if (p1.mauSo != 0 && p2.mauSo != 0)
            {
                p.tuSo = p1.tuSo * p2.mauSo - p1.mauSo * p2.tuSo;
                p.mauSo = p1.mauSo * p2.mauSo;
            }
            else
            {
                Console.WriteLine(" Error.");
            }

            return p;
        }

        public static PhanSo operator *(PhanSo p1, PhanSo p2)
        {
            PhanSo p = new PhanSo();

            if (p1.mauSo != 0 && p2.mauSo != 0)
            {
                p.tuSo = p1.tuSo * p2.tuSo;
                p.mauSo = p1.mauSo * p2.mauSo;
            }
            else
            {
                Console.WriteLine(" Error.");
            }

            return p;
        }

        public static PhanSo operator /(PhanSo p1, PhanSo p2)
        {
            PhanSo p = new PhanSo();

            if (p1.mauSo != 0 && p2.tuSo != 0)
            {
                p.tuSo = p1.tuSo * p2.mauSo;
                p.mauSo = p1.mauSo * p2.tuSo;
            }
            else
            {
                Console.WriteLine(" Error");
            }

            return p;
        }
    }
}
