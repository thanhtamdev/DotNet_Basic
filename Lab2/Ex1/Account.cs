using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Account
    {
        private string maSoTK;
        private int soTien;

        public Account(string maSoTK, int soTien)
        {
            this.maSoTK = maSoTK;
            this.soTien = soTien;
        }

        public string MaSoTK
        {
            get
            {
                return maSoTK;
            }

            set
            {
                maSoTK = value;
            }
        }

        public int SoTien
        {
            get
            {
                return soTien;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("\n Khong the cap nhat so tien < 0.");
                }
                else
                {
                    soTien = value;
                }
            }
        }
    }
}
