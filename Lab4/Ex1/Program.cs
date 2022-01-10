using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(1, 2);
            Vector b = new Vector(-5, 15);

            Vector add = a + b;
            Vector sub = a - b;

            Console.WriteLine(" Ket qua a + b = ({0}; {1}) ", add.X, add.Y);
            Console.WriteLine(" Ket qua a - b = ({0}; {1}) ", sub.X, sub.Y);
        }
    }
}
