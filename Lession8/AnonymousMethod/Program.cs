using System;

namespace AnonymousMethod
{
    // 1, Khai báo delegate
    public delegate int Caculator(int x, int y);
    class Program
    {
        //public static int TinhTong(int a, int b)
        //{
        //    return a + b;
        //}
        static void Main(string[] args)
        {
            // 2. Khởi tạo delegate
            //Caculator caculator = TinhTong;
            // Func<int, int, int> func = TinhTong;

            // Phương thức nặc danh là 1 khối code không có tên và được khai báo bằng từ khóa delegate
            //Func<int, int, int> func = delegate (int a, int b)
            //{
            //    return a + b;
            //};
            // 3. Thực thi
            //Console.WriteLine(" Tong la: " + func(2, 3));


            // Biểu thức Lambda: là cách viết rút gọn của phương thức nặc danh
            //Func<int, int, int> func = delegate (int a, int b)    // Hàm nặc danh

            //Func<int, int, int> func = (int a, int b) =>  // thay delegate thành =>
            //{
            //    return a + b;
            //};

            // Bỏ { } và từ khóa return
            //Func<int, int, int> func = (int a, int b) => ( a + b);   

            // Bỏ kiểu dữ liệu của các tham số
            Func<int, int, int> func = (a, b) => (a + b);
        }
    }
}
