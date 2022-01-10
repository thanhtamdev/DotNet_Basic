using System;

namespace MethodGeneric
{
    class Program
    {
        //private static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        //private static void Swap(ref double a, ref double b)
        //{
        //    double temp = a;
        //    a = b;
        //    b = temp;
        //}

        //private static void Swap(ref char a, ref char b)
        //{
        //    char temp = a;
        //    a = b;
        //    b = temp;
        //}

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            // Hoán vị hai số nguyên
            int a = 3, b = 5;
            double c = 1.5, d = 5.12;
            char m = 'a', n = 'b';
            Console.WriteLine(" Truoc khi hoan vi a = {0} va b = {1}", a, b);

            Swap<int>(ref a, ref b);

            Console.WriteLine(" Sau khi hoan vi a = {0} va b = {1}", a, b);

            Console.WriteLine(" Truoc khi hoan vi c = {0} va d = {1}", c, d);

            Swap<double>(ref c, ref d);

            Console.WriteLine(" Sau khi hoan vi c = {0} va d = {1}", c, d);

            Console.WriteLine(" Truoc khi hoan vi m = {0} va n = {1}", m, n);

            Swap<char>(ref m, ref n);

            Console.WriteLine(" Sau khi hoan vi n = {0} va n = {1}", m, n);

        }
    }
}
