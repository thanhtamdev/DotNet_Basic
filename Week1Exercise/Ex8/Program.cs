using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập số nguyên dương n (n > 0). Liệt kê n số chính phương đầu tiên

            int n = 0;

            do
            {
                Console.Write(" Nhap so nguyen duong: n = ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            int i = 0;

            while (i < n)
            {
                Console.WriteLine(" " + i * i);

                i++;
            }
        }
    }
}
