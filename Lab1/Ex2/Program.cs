using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("B1234", "Mindset", 150_000, 50_000);

            Console.WriteLine(" Thong tin sach: ");
            Console.WriteLine(" - Ma so sach: " + b.GetBookCode());
            Console.WriteLine(" - Ten sach: " + b.GetBookTitle());
            Console.WriteLine(" - Gia sach: " + b.GetBookshelves());
            Console.WriteLine(" - Gia giam: " + b.GetDiscount());
            Console.WriteLine();
            Console.WriteLine(" - Gia ban cua cuon sach: " + b.PriceOfABook());

            b.SetDiscount(120_000);

            Console.WriteLine("\n Thong tin sach sau khi cap nhat: ");
            Console.WriteLine(" - Ma so sach: " + b.GetBookCode());
            Console.WriteLine(" - Ten sach: " + b.GetBookTitle());
            Console.WriteLine(" - Gia sach: " + b.GetBookshelves());
            Console.WriteLine(" - Gia giam: " + b.GetDiscount());
            Console.WriteLine();
            Console.WriteLine(" - Gia ban cua cuon sach: " + b.PriceOfABook());
        }
    }
}
