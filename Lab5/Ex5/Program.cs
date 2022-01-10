using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Software sw = new Software("S01", 1_500_000, "1.2.0");
            Hardware hw = new Hardware("H001", 500_000, 1.5);

            Console.WriteLine(" Thong tin phan mem: ");
            Console.WriteLine(" - Ten phan mem: " + sw.Name);
            Console.WriteLine(" - Gia: " + sw.Price);
            Console.WriteLine(" - Phien ban: " + sw.Version);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Thong tin phan cung: ");
            Console.WriteLine(" - Ten phan cung: " + hw.Name);
            Console.WriteLine(" - Gia: " + hw.Price);
            Console.WriteLine(" - Khoi luong: " + hw.Weight);
        }
    }
}
