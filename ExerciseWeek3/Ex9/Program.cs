using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào 1 dãy số nguyên gồm n phần tử.Hãy thêm một phần
            //tử có giá trị x vào mảng tại vị trí k.

            int n = 0;

            do
            {
                Console.Write(" Nhap so luong phan tu cua mang: n = ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write(" Nhap gia tri cho arr[" + i + "] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // xuat mang
            Console.Write(" Day so ban vua nhap: ");

            foreach (var item in arr)
            {
                Console.Write(" " + item + " ");
            }

            Console.WriteLine();

            // Them gia tri x vao vi tri k

            int x = 0;
            int k = 0;

            Console.Write(" Nhap gia tri can them x = ");
            x = int.Parse(Console.ReadLine());

            do
            {
                Console.Write(" Nhap vi tri can them: ");
                k = int.Parse(Console.ReadLine());
            } while (k < 0 || k >= n);

            n = n + 1;
            int[] newArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i < k)
                    newArr[i] = arr[i];
                else if (i == k)
                    newArr[i] = x;
                else
                    newArr[i] = arr[i - 1];
            }

            Console.Write(" Mang sau khi them x = {0} vao vi tri k = {1}: ", x, k);

            for (int i = 0; i < n; i++)
                Console.Write(newArr[i] + " ");
            Console.WriteLine();
        }
    }
}
