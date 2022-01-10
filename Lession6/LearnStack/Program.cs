using System;
using System.Collections;

namespace LearnStack
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Khai báo và khởi tạo stack
            Stack stack = new Stack();

            // Thêm phần tử
            stack.Push(1);
            stack.Push(5);
            stack.Push(-12.5);
            stack.Push('a');

            // Lấy phần tử ra và xóa phần tử ở đỉnh stack
            stack.Pop();

            // Lấy ra và không xóa phần tử ở đỉnh stack
            stack.Peek();

            // Duyệt các phần tử
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
