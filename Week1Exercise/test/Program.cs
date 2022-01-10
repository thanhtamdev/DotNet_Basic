using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Tinh tong hai so!");
            Console.Write(" Nhap so a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" Nhap so b = ");
            int b = int.Parse(Console.ReadLine());

            int res = a + b;

            Console.WriteLine(" Tong hai so: " + res);


            int x;

            // ngoại lệ
            try
            {
                x = int.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine(" so x khong hop le" + e.Message);
                return;
            }

            // khai báo mảng
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] += 1;
            }

            foreach(int item in arr)
            {
                Console.WriteLine(" " + item);
            }
        }

        // ham tinh tong hai so
        static int tinhTong(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// check prime number
        /// </summary>
        /// <param name="n"></param>
        /// <returns>true if is prime and false if isn't prime</returns>
        static bool isPrime(int n)
        {
            if(n < 2)
            {
                return false;
            }
            else
            {
                for(int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if(n % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
