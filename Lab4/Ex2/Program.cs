using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(12, 3);
            Vector b = new Vector(12, 3);

            if (a == b)
            {
                Console.WriteLine(" Hai vector a va b bang nhau.");
            }
            else
            {
                Console.WriteLine(" Hai vector a va b khong bang nhau.");
            }
        }
    }
}
