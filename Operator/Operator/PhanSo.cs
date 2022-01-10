using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public int TuSo
        {
            get
            {
                return tuSo;
            }
        }

        public int MauSo
        {
            get
            {
                return mauSo;
            }
        }

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

        public PhanSo Add(PhanSo ps)
        {
            PhanSo res = new PhanSo();

            res.tuSo = tuSo * ps.mauSo + mauSo * ps.tuSo;
            res.mauSo = mauSo * ps.mauSo;

            return res;
        }

        public PhanSo Sub(PhanSo ps)
        {
            PhanSo res = new PhanSo();

            res.tuSo = tuSo * ps.mauSo - mauSo * ps.tuSo;
            res.mauSo = mauSo * ps.mauSo;

            return res;
        }

        // Operator overloading
        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            PhanSo res = new PhanSo();

            res.tuSo = ps1.tuSo * ps2.tuSo;
            res.mauSo = ps1.mauSo * ps2.mauSo;

            return res;
        }

        public PhanSo operator -(PhanSo ps1 , PhanSo ps2)
        {
            PhanSo res = new PhanSo();

            res.tuSo = ps1.tuSo * ps2.mauSo - ps1.mauSo * ps2.tuSo;
            res.mauSo = ps1.mauSo * ps2.mauSo;

            return res;
        }

        public PhanSo Div(PhanSo ps)
        {
            PhanSo res = new PhanSo();

            res.tuSo = tuSo * ps.mauSo;
            res.mauSo = mauSo * ps.mauSo;

            return res;
        }
    }
}
