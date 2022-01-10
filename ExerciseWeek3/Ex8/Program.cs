using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình tìm giá trị dương đầu tiên trong mảng 1 chiều các số thực.
            // Nếu mảng không có giá trị dương thì trả về giá trị -1

            int n = 0;

            do
            {
                Console.Write(" Nhap so luong phan tu cua mang: n = ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            double[] a = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write(" a[" + i + "] = ");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }

            int pos = (-1);

            for (int i = 0; i < n; i++)
            {
                if(a[i] > 0)
                {
                    pos = i;
                    break;
                }
            }

            if(pos != (-1))
            {
                Console.WriteLine(" Vi tri cua gia tri duong dau tien: " + pos);
            }
            else
            {
                Console.WriteLine(" Mang khong co gia tri duong.");
            }
        }
    }
}