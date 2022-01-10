using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            NhapSo(a);
            //HienThi(a);
        }

        private static int ReadNumber(int min, int max)
        {
            int n = 0;

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num <= min || num >= max)
                {
                    throw new Exception(" Invalid data");
                }
                else
                {
                    n = num;
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(" Loi nhap lieu: " + fe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(" Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine();
            }

            return n;
        }

        private static void NhapSo(int[] a)
        {

            Console.Write(" Nhap so nguyen thu 1: ");
            a[0] = ReadNumber(1, 100);

            try
            {
                if (a[0] > 1 && a[0] < 100)
                {
                    for (int i = 1; i < a.Length; i++)
                    {
                        try
                        {

                            Console.Write(" Nhap so nguyen {0}: ", (i + 1));
                            int tmp = ReadNumber(a[i - 1], 100);

                            if (tmp <= a[i - 1] || tmp >= 100)
                            {
                                break;
                            }
                            else
                            {
                                a[i] = tmp;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(" Exception: " + e.Message);
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private static void HienThi(int[] a)
        {
            foreach (var item in a)
            {
                Console.Write(" " + item + " ");
            }
        }
    }
}
