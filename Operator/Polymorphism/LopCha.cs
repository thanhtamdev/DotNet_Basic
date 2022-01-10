using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class LopCha
    {
        private int tienTrongViCha;

        public LopCha()
        {
            tienTrongViCha = 100;
        }

        public void RutTien(int soTien)
        {
            int soTienConLai = tienTrongViCha - soTien;

            Console.WriteLine(" Tien con lai trong vi cha: " + soTienConLai);
        }
    }
}
