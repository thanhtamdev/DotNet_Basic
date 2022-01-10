using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình liệt kê các vị trí mà giá trị tại đó là giá trị âm trong mảng 1
            //chiều.

            int n = 0;

            do
            {
                Console.Write(" Nhap so luong phan tu cua mang: n = ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write(" Nhap gia tri cho phan tu a[" + i + "] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write(" Cac vi tri co gia tri am trong mang: ");

            for (int i = 0; i < n; i++)
            {
                if(a[i] < 0)
                {
                    Console.Write(" " + i + " ");
                }
            }
        }
    }
}
