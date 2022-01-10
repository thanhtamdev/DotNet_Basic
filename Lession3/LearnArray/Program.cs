using System;

namespace LearnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. khai báo mảng:
            // Cách 1: data_type[] name_array = new data_type[size_array];
            // Cách 2: data_type[] name_array = new data_type[]{val1, val2, val3,..., valn};
            // Cách 3: data_type[] name_array = {val1, val2, val3,..., valn};

            int[] a = new int[10];
            int[] b = new int[] { 1, 3, 5, 7, 9 };
            int[] c = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            // 2. Xác định độ dài của mảng: name_array.Length
            Console.WriteLine(c.Length);

            // 3. Truy cập các phần tử của mảng
            // name_array[index] - index = 0 -> length - 1
            Console.WriteLine(c[1]);

            // 4. Duyệt mảng
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + "\t");
            }
        }
    }
}
