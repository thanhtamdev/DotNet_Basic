using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
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

        public static bool operator >(PhanSo a, PhanSo b)
        {
            if (a.tuSo*b.mauSo > b.tuSo*a.mauSo)
            {
                return true;
            }

            return false;
        }

        public static bool operator <(PhanSo a, PhanSo b)
        {
            if (a.tuSo * b.mauSo < b.tuSo * a.mauSo)
            {
                return true;
            }

            return false;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
