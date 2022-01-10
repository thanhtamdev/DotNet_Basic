using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Một số hoàn thiện là một số có tổng các ước số của nó (không kể nó) bằng chính nó.
            // Hãy liệt kê các số hoàn thiện nhỏ hơn 5000.

            Console.Write(" Cac so hoan thien nho hon 5000 la: ");
            for(int i = 1; i < 5000; i++)
            {
                int sum = 0;

                for(int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        sum += j;
                    }
                }

                if (sum == i)
                {
                    Console.Write(" " + i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
