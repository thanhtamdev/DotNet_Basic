using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình tính diện tích và chu vi hình tròn
            // với bán kính được nhập từ bàn phím.

            double r = 0;

            do
            {
                Console.Write(" Nhap ban kinh cua hinh tron (r > 0): r = ");
                r = double.Parse(Console.ReadLine());
            } while (r <= 0);

            double P = 2 * Math.PI * r;
            double S = Math.PI * r * r;

            Console.WriteLine(" Chu vi cua hinh tron: " + P);
            Console.WriteLine(" Dien tich cua hinh tron: " + S);
        }
    }
}
