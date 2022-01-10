using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình nhập vào họ tên của 1 sinh viên từ bàn phím.
            // Kiểm tra sinh viên đó có phải họ "Nguyễn" hay không?

            Console.Write(" Nhap ho va ten sinh vien: ");
            string fullName = Console.ReadLine().Trim();

            bool res = fullName.StartsWith("Nguyen");

            if (res)
            {
                Console.WriteLine(" Sinh vien vua nhap ho Nguyen.");
            }
            else
            {
                Console.WriteLine(" Sinh vien vua nhap co ho khong phai ho Nguyen.");
            }
        }
    }
}
