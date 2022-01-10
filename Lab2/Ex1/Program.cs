using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("001", 1_500_000);

            Console.WriteLine("\n Thong tin tai khoan: ");
            Console.WriteLine(" - Ma so tai khoan: " + acc.MaSoTK);
            Console.WriteLine(" - So tien: " + acc.SoTien);

            acc.SoTien = -2_000_000;

            Console.WriteLine("\n Thong tin tai khoan: ");
            Console.WriteLine(" - Ma so tai khoan: " + acc.MaSoTK);
            Console.WriteLine(" - So tien: " + acc.SoTien);

        }
    }
}
