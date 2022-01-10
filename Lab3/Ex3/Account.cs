using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Account
    {
        private string maSoTK;
        private int soTien;

        public Account()
        {
            maSoTK = "";
            soTien = 0;
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
                soTien = value;
            }
        }

        public void Input()
        {
            Console.Write(" Nhap ma so tai khoan: ");
            maSoTK = Console.ReadLine().Trim().Replace(" ", "");

            do
            {
                Console.Write(" Nhap so tien: ");
                soTien = Convert.ToInt32(Console.ReadLine());
            } while (soTien < 0);
        }

        public void Output()
        {
            Console.WriteLine(" - Ma so tai khoan: " + maSoTK);
            Console.WriteLine(" - So tien: " + soTien);
        }
    }
}
