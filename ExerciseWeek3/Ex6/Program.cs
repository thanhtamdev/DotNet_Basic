using System;
using System.Text;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình chuyển chuỗi tiếng Việt có dấu thành không dấu.
            //**** Chưa làm đc
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write(" Enter string: ");
            string s = Console.ReadLine();

            Console.WriteLine(s);
        }
    }
}
