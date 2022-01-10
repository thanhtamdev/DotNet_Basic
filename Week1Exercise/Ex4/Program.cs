using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình nhập số nguyên dương n. Liệt kê n số nguyên tố đầu tiên.
            int n = 0;

            do
            {
                Console.Write(" Nhap so luong so nguyen to: n = ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            int count = 0;
            int i = 2;

            while(count < n) {
                bool mark = true;

                for(int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        mark = false;
                        break;
                    }
                }
                    
                if (mark == true)
                {
                    count++;

                    Console.WriteLine(" " + i);
                }

                i++;
            }
        }
    }
}
