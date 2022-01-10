using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình đếm số ước số của số nguyên dương N.

            int N = 0;

            do {
                Console.Write(" Nhap so nguyen dương: N = ");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0);

            int count = 0;

            for(int i = 1; i <= N; i++)
            {
                if(N % i == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(" So uoc cua N = " + N + " la: " + count);
        }
    }
}
