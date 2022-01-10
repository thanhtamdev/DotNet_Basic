using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfDefineException
{
    class KhachHang
    {
        private string hoTen;
        private int tuoi;   // 16 <= tuoi <= 80

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public int Tuoi
        {
            get
            {
                return tuoi;
            }

            set
            {
                try
                {
                    if (value < 16 || value > 80)
                    {
                        throw new KhachHangException("Tuoi khong hop le!");
                    }
                    else
                    {
                        tuoi = value;
                    }
                }
                catch (KhachHangException ex)
                {
                    Console.WriteLine(" Loi: " + ex.Message);
                }
            }
        }
    }
}
