using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình nhập vào họ tên sinh viên.
            // In ra màn hình tên sinh viên vừa nhập

            Console.Write(" Nhap ho va ten sinh vien: ");
            string fullName = Console.ReadLine().Trim();

            int theLastSapce = fullName.LastIndexOf(' ');

            Console.WriteLine(" Name: " + fullName.Substring(theLastSapce + 1));
        }
    }
}
