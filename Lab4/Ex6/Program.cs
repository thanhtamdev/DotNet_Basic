using System;

namespace Ex6
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

            BubbleSort(ref phanSo);

            Console.Write(" Sau khi sap xep tang dan: ");

            foreach (var item in phanSo)
            {
                item.XuatPS();
            }

            PhanSo psMax = FindMax(phanSo);
            Console.Write("\n Phan so lon nhat: ");
            psMax.XuatPS();
        }

        private static PhanSo FindMax(PhanSo[] p)
        {
            PhanSo max = p[0];

            foreach (var item in p)
            {
                if(max < item)
                {
                    max = item;
                }
            }

            return max;
        }

        private static void BubbleSort(ref PhanSo[] a)
        {
            bool nochange = true;
            for (int i = 0; i < a.Length - 1; i++)
            {
                nochange = true;

                for (int j = a.Length - 1; j > i; j--)
                {
                    if (a[j] < a[j - 1])
                    {
                        swap(ref a[j], ref a[j - 1]);
                        nochange = false;
                    }
                }

                if (nochange)
                    break;
            }
        }

        private static void swap(ref PhanSo a, ref PhanSo b)
        {
            PhanSo tmp = a;
            a = b;
            b = tmp;
        }
    }
}
