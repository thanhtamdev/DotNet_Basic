using System;

namespace Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.Write(" Nhap so luong hinh can nhap thong tin va tinh dien tich: n = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            Shape[] s = new Shape[n];

            Enter(s);
            Display(s);

            Console.WriteLine(" Tong dien tich cac hinh: " + SumArea(s));

        }

        private static void Enter(Shape[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("\n Nhap hinh thu " + (i + 1) + ":");

                string val = "";

                Console.Write(" Loai hinh (Neu hinh chu nhat nhap ‘T’, hinh tron nhap ‘C’): ");
                val = Console.ReadLine().ToLower();

                if (String.Compare(val, "c") == 0)
                {
                    s[i] = new Circle();
                    s[i].Input();
                }
                else
                {
                    s[i] = new Rectangle();
                    s[i].Input();
                }
            }
        }

        private static void Display(Shape[] s)
        {
            Console.WriteLine("\n Cac hinh da nhap:");

            foreach (var item in s)
            {
                item.Output();
            }
        }

        private static double SumArea(Shape[] s)
        {
            double sum = 0;

            foreach (var item in s)
            {
                sum += item.Area();
            }

            return sum;
        }
    }
}
