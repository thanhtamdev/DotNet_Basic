using System;

namespace LearnException
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 20;
            //int b = 0;
            //int c;

            int a, b, c;

            Console.Write(" Nhap a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap b = ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Gia tri cua a = " + a);
            Console.WriteLine(" Gia tri cua b = " + b);

            // xử lí ngoại lệ bằng logical implementation
            if (b == 0)
            {
                Console.WriteLine(" Khong the chia cho 0;");
            }
            else
            {
                c = a / b;

                Console.WriteLine(" Gia tri cua c = " + c);
            }
        }
    }
}
