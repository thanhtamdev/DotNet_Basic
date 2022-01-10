using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.Write(" Nhap so luong trai bong: n = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            Ball[] ball = new Ball[n];

            NhapTT(ball);
            HienThiTT(ball);
        }

        private static void NhapTT(Ball[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("\n Nhap thong tin trai bong thu " + (i + 1));

                b[i] = new Ball();
                b[i].Input();
            }
        }

        private static void HienThiTT(Ball[] b)
        {
            foreach (var item in b)
            {
                Console.WriteLine("\n Thong tin trai bong: ");
                item.Output();
            }
        }
    }
}
