using System;

namespace Ex1
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
                int sub = a - b;
                int mult = a * b;
                int div = a / b;
                //double div = Convert.ToDouble(a) / b;

                Console.WriteLine(" a + b = " + add);
                Console.WriteLine(" a - b = " + sub);
                Console.WriteLine(" a * b = " + mult);
                Console.WriteLine(" a / b = " + div);
            }
            catch (FormatException f)
            {
                Console.WriteLine(" Loi nhap lieu: " + f.Message);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(" Loi chia cho 0: " + d.Message);
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}
