using System;

namespace Sup
{
    class Program
    {
        // Bài 4: Nhập vào bộ 3 số kiểm tra đó có là ba cạnh của tam giác hay không?
        static void Main(string[] args)
        {
            Console.Write(" Nhap so thu nhat: a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write(" Nhap so thu nhat: b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write(" Nhap so thu nhat: c = ");
            int c = int.Parse(Console.ReadLine());

            if(a > 0 && b > 0 && c > 0 && (a + b) > c && (a + c) > b && (b + c) > a)
            {
                Console.WriteLine(" Bo ba so {0}, {1},{2} la ba canh cua tam giac." , a, b, c);
            }
            else
            {
                Console.WriteLine(" Bo ba so {0}, {1},{2} KHONG la ba canh cua tam giac.", a, b, c);
            }
        }
    }
}
