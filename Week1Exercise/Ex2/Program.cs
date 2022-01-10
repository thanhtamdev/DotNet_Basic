using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình nhập vào một số nguyên n gồm ba chữ số.
            // Xuất ra màn hình chữ số lớn nhất ở vị trí nào ?

            int n = 0;

            do
            {
                System.Console.Write(" Nhap so co 3 chu so: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 100 || n > 999);

            int donVi = n % 10;
            int chuc = n / 10 % 10;
            int tram = n / 100;

            int max = donVi;

            if(max < tram)
            {
                max = tram;
            }

            if (max < chuc)
            {
                max = chuc;
            }

            string hang = (tram == max && chuc == max && donVi == max) ? "ca ba hang tram, chuc va don vi"
                : (tram == chuc && tram == max) ? "hang tram va chuc" :
                (tram == donVi && donVi == max) ? "hang tram va don vi" :
                (chuc == donVi && donVi == max) ? "hang chuc va don vi" :
                (tram == max) ? "hang tram" : (chuc == max) ? "hang chuc" : "hang don vi";

            Console.WriteLine(" Chu so lon nhat nam o " + hang + " (" + max + ")");
        }
    }
}
