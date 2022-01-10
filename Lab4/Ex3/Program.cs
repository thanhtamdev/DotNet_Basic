using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector(15, 5);

            Vector kq = v + 5;

            Console.WriteLine(" Ket qua: ({0}, {1})", kq.X, kq.Y);
        }
    }
}
