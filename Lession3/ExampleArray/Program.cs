using System;

namespace ExampleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập 1 mảng số nguyên gồm n phần tử. Tính tổng các số lẻ trong mảng
            //int n = 0;

            //Console.Write(" Nhap so luong phan tu cua mang: n = ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(" Nhap gia tri cho phan tu ar[" + i + "] = ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        sum += arr[i];
            //    }
            //}

            //foreach (var item in arr)
            //{
            //    if (item % 2 != 0)
            //    {
            //        sum += item;
            //    }
            //}

            //Console.WriteLine("\n Tong cac so le co trong mang: " + sum);

            // Ví dụ 2: Nhập vào một dãy số nguyên không biết trước số lượng.
            // Việc nhập kết thúc khi gặp -1
            // Sau đó, nhập vào 1 số nguyên x và vị trí cần chèn trong mảng đã nhập.
            // Thực hiện chèn x vào vị trí k trong dãy vừa nhập

            
            Console.WriteLine(" Nhap day so nguyen: ");

            int i = 0;
            int n = 0;
            int[] numbers = new int[];

            while (true)
            {
                Console.Write(" numbers[" + i +"] = ");
                numbers[i] = int.Parse(Console.ReadLine());
                

                if(numbers[i] == (-1))
                {
                    break;
                }

                n++;
                i++;
            }

            

            foreach (var item in numbers)
            {
                Console.Write(item);
            }

        }
    }
}
