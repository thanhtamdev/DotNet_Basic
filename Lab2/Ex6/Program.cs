using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = new Color(1, 2, 110, 4);
            Console.WriteLine(color.Grayscale());
        }
    }
}
