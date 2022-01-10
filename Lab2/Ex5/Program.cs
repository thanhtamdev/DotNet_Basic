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
                Console.Write(" Nhap so luong hinh tron: n = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            Circle[] c = new Circle[n];

            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("\n Nhap thong tin cho hinh tron thu " + (i + 1) + ":");
                Console.Write(" Nhap ban kinh: r = ");
                c[i] = new Circle();
                c[i].BanKinh = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\n " + n + " duong tron da nhap:");

            foreach (var item in c)
            {
                Console.WriteLine(" Ban kinh: r = " + item.BanKinh);
            }

            double[] dienTich = new double[n];

            for (int i = 0; i < dienTich.Length; i++)
            {
                dienTich[i] = Math.PI * c[i].BanKinh * c[i].BanKinh;
            }

            Console.WriteLine("\n Dien tich cua " + n + " duong tron: ");

            for (int i = 0; i < dienTich.Length; i++)
            {
                Console.WriteLine(" Dien tich cua duong tron " + (i + 1) + ": " + dienTich[i]);
            }

            double max = dienTich[0];

            for (int i = 1; i < dienTich.Length; i++)
            {
                if (max < dienTich[i])
                {
                    max = dienTich[i];
                }
            }

            Console.WriteLine("\n Dien tich duong tron lon nhat: S = " + max);
        }
    }
}
