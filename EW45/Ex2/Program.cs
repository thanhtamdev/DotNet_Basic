using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            try
            {
                Console.Write(" Nhap a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Nhap b = ");
                b = Convert.ToInt32(Console.ReadLine());

                int add = a + b;

                Console.WriteLine(" Tong a + b = " + add);
            }
            catch (FormatException f)
            {
                Console.WriteLine(" Loi nhap lieu: " + f.Message);
                Console.WriteLine(" Vui long nhap lai hai so nguyen.");
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}
