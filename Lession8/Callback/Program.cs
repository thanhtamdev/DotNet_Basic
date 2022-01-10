using System;

namespace Callback
{
    public delegate void MyDelegate(string s);
    class Program
    {
        public static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;   // Thiết lập màu chữ
            Console.WriteLine(" Info: " + s);
            Console.ResetColor();   // Trả lại màu mặc định
        }

        public static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Warning: " + s);
            Console.ResetColor();
        }

        public static void TinhTong(int a, int b, MyDelegate callBack)
        {
            int c = a + b;
            callBack(" Tong la: " + c);
        }

        static void Main(string[] args)
        {
            TinhTong(2, 3, Info);
            TinhTong(3, 3, Warning);
        }
    }
}
