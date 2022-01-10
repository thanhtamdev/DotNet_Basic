using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập số nguyên dương n (n > 0). Đếm xem có bao nhiêu số hoàn thiện < n.

            int n = 0;

            do
            {
                Console.Write(" Nhap so nguyen duong: n = ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            int count = 0;

            for(int i = 1; i < n; i++)
            {
                int sum = 0;

                for(int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        sum += j;
                    }
                }

                if(sum == i)
                {
                    count++;
                }
            }

            Console.WriteLine(" Co {0} so hoan thien nho hon {1}", count, n);
        }
    }
}
