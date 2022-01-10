using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo(3, 4);
            PhanSo ps2 = new PhanSo(1, 5);
            PhanSo kq = ps1 * (ps2);

            Console.WriteLine(" Ket qua: {0}/{1}", kq.TuSo, kq.MauSo);
        }
    }
}
