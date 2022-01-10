using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình nhập vào số nguyên n gồm ba chữ số.
            // Xuất ra màn hình theo thứ tự tăng dần của các chữ số.

            int n = 0;

            do
            {
                Console.Write(" Nhap so co ba chu so: n = ");
                n = int.Parse(Console.ReadLine());
            } while (n < 100 || n > 999);

            int a = n % 10;
            int b = n / 10 % 10;
            int c = n / 100;

            int max = a;

            if(max < b)
            {
                max = b;
            }

            if(max < c)
            {
                max = c;
            }

            int min = a;

            if(min > b)
            {
                min = b;
            }

            if(min > c)
            {
                min = c;
            }

            int mid = a + b + c - (min + max);

            Console.WriteLine(" Thu tu tang dan cua cac chu so: " + min + mid + max);
        }
    }
}
