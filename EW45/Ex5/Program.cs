using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number n = new Number();

            //n.NhapVaTinhCBH();

            int N;

            try
            {
                Console.Write(" Nhap N = ");
                N = Convert.ToInt32(Console.ReadLine());

                if (N < 0)
                {
                    throw new Exception("Invalid number");
                }
                else
                {
                    double res = Math.Sqrt(Convert.ToDouble(N));

                    Console.WriteLine(" Can bac hai cua {0} la: {1}", N, res);
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(" Exception: " + fe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(" Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine(" Good bye.");
            }
        }
    }
}
