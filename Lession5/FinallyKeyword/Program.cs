using System;

namespace FinallyKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            NhapSN();
        }

        public static void NhapSN()
        {
            int x;

            Console.Write(" Nhap so nguyen x = ");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" x = " + x);
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(" Loi nhap lieu: " + ex1.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return;
            }
            finally
            {
                Console.WriteLine(" Ket thuc nhap lieu!");
            }
        }
    }
}
