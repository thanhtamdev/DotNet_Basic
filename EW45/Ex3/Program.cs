using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            SinhMang(arr);
            //InMang(arr);

            int k;

            try
            {
                Console.Write(" Nhap chi so: k = ");
                k = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("arr[{0}] = {1}", k, arr[k]);
            }
            catch (FormatException fm)
            {
                Console.WriteLine(" Loi nhap lieu: " + fm.Message);
            }
            catch (System.IndexOutOfRangeException o)
            {
                Console.WriteLine(" Loi: " + o.Message);
            }
        }

        private static void SinhMang(int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i] = rand.Next();
                arr[i] = rand.Next(0, 1000);
            }
        }

        private static void InMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" arr[{0}] = {1}", i, arr[i]);
            }
        }
    }
}
