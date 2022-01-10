using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình nhập vào hai số nguyên dương a và b.
            // Tìm ước số chung lớn nhất và bội số chung nhỏ nhất của a và b.

            int a = 0, b = 0;

            do
            {
                Console.Write(" Nhap so nguyen duong thu nhat: a = ");
                a = int.Parse(Console.ReadLine());
            } while (a <= 0);

            do
            {
                Console.Write(" Nhap so nguyen duong thu hai: b = ");
                b = int.Parse(Console.ReadLine());
            } while (b <= 0);

            int n1 = a, n2 = b;

            int tmp;

            while (n2 != 0)
            {
                tmp = n2;
                n2 = n1 % n2;
                n1 = tmp;
            }

            int ucln = Math.Abs(n1);

            Console.WriteLine(" UCLN(" + a + ", " + b + ") = " + ucln);

            int bcnn = a * b / ucln;

            Console.WriteLine(" BCNN(" + a + ", " + b + ") = " + bcnn);
        }
    }
}
