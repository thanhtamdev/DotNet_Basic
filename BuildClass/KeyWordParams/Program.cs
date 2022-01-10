using System;

namespace KeyWordParams
{
    class Program
    {
        public static int findMax(params int[] arr)
        {
            int max = arr[0];

            foreach (var item in arr)
            {
                if (max < item)
                {
                    max = item;
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            // Viết phương thức tìm max của mảng số nguyên
            int[] arr = { 1, -12, 90, -123, 120, 11, 125 };
            int[] arr1 = { 3, 1, 0, 9, 12 };
            int[] arr2 = { 0, -3, 6, 5, 75 };

            Console.WriteLine(" Max cua mang arr: " + findMax(arr));
            Console.WriteLine(" Max cua mang arr1: " + findMax(arr1));
            Console.WriteLine(" Max cua mang arr2: " + findMax(arr2));

            // Cách truyền trực tiếp danh sách các số nguyên cho hàm findMax mà ko cần khởi tạo mảng
            // Dùng từ khóa params
            Console.WriteLine(" Max of array arr: " + findMax(1, -12, 90, -123, 120, 11, 125));

        }
    }
}
