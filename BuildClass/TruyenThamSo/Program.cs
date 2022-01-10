using System;

namespace TruyenThamSo
{
    class Program
    {
        private int number;
        public static void swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static void Main(string[] args)
        {
            // Viết phương thức hoán vị hai số nguyên
            int x = 3;
            int y = 4;

            Console.WriteLine(" Before swap: x = {0}, y = {1}", x, y);

            Program.swap(ref x, ref y);
            // ref và out: dùng để truyền tham chiếu
            // out - không cần gán giá trị cho biến trước khi gọi
            //ref - gán giá trị cho biến truyền vào trước khi gọi

            Console.WriteLine(" After swap: x = {0}, y = {1}", x, y);
        }
    }
}
