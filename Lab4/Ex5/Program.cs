using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.Write(" Nhap so luong phan so: n = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            PhanSo[] phanSo = new PhanSo[n];

            for (int i = 0; i < phanSo.Length; i++)
            {
                Console.WriteLine("\n Nhap phan so thu " + (i + 1));
                phanSo[i] = new PhanSo();
                phanSo[i].NhapPS();
            }

            PhanSo sum = new PhanSo();

            foreach (var item in phanSo)
            {
                sum+= item;
            }

            int ucln = TimUCLN(sum.TuSo, sum.MauSo);
            sum.TuSo /= ucln;
            sum.MauSo /= ucln;

            Console.Write(" Tong S = ");
            for (int i = 0; i < phanSo.Length; i++)
            {
                if(i > 0)
                {
                    Console.Write(" +");
                    phanSo[i].XuatPS();
                }
                else
                {
                    phanSo[i].XuatPS();
                }
            }

            Console.Write(" = ");
            sum.XuatPS();

        }

        public static int TimUCLN(int a, int b)
        {
            int tmp = 0;

            while (b != 0)
            {
                tmp = b;
                b = a % b;
                a = tmp;
            }

            return a;
        }
    }
}
