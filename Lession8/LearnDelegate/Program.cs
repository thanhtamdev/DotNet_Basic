using System;

namespace LearnDelegate
{
    // 1. Khai báo delegate:
    // delegate <kiểu trả về> <tên delegate> (<danh sách tha số nếu có>);
    //public delegate int Caculator(int a, int b);
    //public delegate void Greeting(string s);

    class Program
    {
        

        public static int TinhTong(int a, int b)
        {
            return a + b;
        }

        public static int TinhHieu(int a, int b)
        {
            return a - b;
        }

        public static void SayHello(string name)
        {
            Console.WriteLine(" Hello " + name);
        }

        static void Main(string[] args)
        {

            // Gọi phương thức: thông qua đối tượng nếu method đó không là static và
            // thông qua tên lớp nếu method là static

            //Program p = new Program();

            //p.TinhTong(2, 3);

            //Program.TinhHieu(5, 1);

            // 2. Khởi tạo delegate
            // cách 1:
            //Caculator cal = new Caculator(TinhHieu);

            // cách 2:
            //Caculator caculator = TinhTong;

            // 3. Thực thi:
            // Cách 1 coi như 1 phương thức:
            //int r = cal(2, 3);
            // Cách 2 coi như 1 đối tượng và gọi đến phương thức Invoke
            //int t = caculator.Invoke(2, 3);

            //Console.WriteLine(" Tong: " + t);
            //Console.WriteLine(" Hieu: " + r);

            //Greeting greeting = SayHello;
            //greeting("World!");

            // *** Trong .net có sẵn 3 delegate
            // Action<>: tham chiếu đến các phương thức có kiểu trả về là void
            // Predicate<>: tham chiếu đến các phương thức có kiểu dữ liệu trả về là kiểu bool
            // Func<>: tham chiếu đến các phương thức có kiểu trả về khác hai kiểu trên

            Func<int, int, int> cal = TinhTong;
            Action<string> greet = SayHello;

            greet("World!");

            // sử dụng delegate giúp gọi lại 1 hàm với vai trò là tham số của 1 hàm khác

        }
    }
}
