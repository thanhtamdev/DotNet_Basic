using System;
using System.Text;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình xóa khoảng trắng giữa các từ

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write(" Enter string: ");
            string str = Console.ReadLine();

            Console.WriteLine(" String after removing spaces between words: " + str.Replace(" ", string.Empty));
        }
    }
}
