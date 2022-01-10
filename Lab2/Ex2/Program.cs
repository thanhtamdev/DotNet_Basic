using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Hello, world!", 125_000, 15_000);

            Console.WriteLine(" Thong tin sach ban dau: ");
            Console.WriteLine(" - Ten sach: " + b.TenSach);
            Console.WriteLine(" - Gia ban: " + b.GiaSach);
            Console.WriteLine(" - Gia giam: " + b.GiamGia);

            // Cap nhat thong tin sach
            Console.Write(" Nhap ten sach can cap nhat: ");
            b.TenSach = Console.ReadLine();
            Console.Write(" Nhap gia ban can cap nhat: ");
            b.GiaSach = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap gia giam: ");
            b.GiamGia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Thong tin sach: ");
            Console.WriteLine(" - Ten sach: " + b.TenSach);
            Console.WriteLine(" - Gia ban: " + b.GiaSach);
            Console.WriteLine(" - Gia giam: " + b.GiamGia);
        }
    }
}
