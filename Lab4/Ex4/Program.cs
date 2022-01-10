using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo();

            Console.WriteLine(" Nhap phan so thu nhat: ");
            a.NhapPS();
            Console.WriteLine(" Nhap phan so thu hai: ");
            b.NhapPS();

            PhanSo add = a + b;
            PhanSo sub = a - b;
            PhanSo mult = a * b;
            PhanSo div = a / b;

            Console.Write(" {0}/{1} + {2}/{3} = ", a.TuSo, a.MauSo, b.TuSo, b.MauSo);
            add.XuatPS();

            Console.Write(" {0}/{1} - {2}/{3} = ", a.TuSo, a.MauSo, b.TuSo, b.MauSo);
            sub.XuatPS();

            Console.Write(" {0}/{1} * {2}/{3} = ", a.TuSo, a.MauSo, b.TuSo, b.MauSo);
            mult.XuatPS();

            Console.Write(" {0}/{1} / {2}/{3} = ", a.TuSo, a.MauSo, b.TuSo, b.MauSo);
            div.XuatPS();
        }
    }
}
