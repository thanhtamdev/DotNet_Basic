using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập số nguyên dương n (0 <= n < 1000) và in ra cách đọc của n

            int n = 0;

            do
            {
                Console.Write(" Nhap so nguyen duong ( 0 <= n < 1000): n = ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0 || n >= 1000);

            int donVi = n % 10;
            int chuc = n / 10 % 10;
            int tram = n / 100;

            switch (tram)
            {
                case 1:
                    Console.Write(" Mot tram");
                    break;

                case 2:
                    Console.Write(" Hai tram");
                    break;

                case 3:
                    Console.Write(" Ba tram");
                    break;

                case 4:
                    Console.Write(" Bon tram");
                    break;

                case 5:
                    Console.Write(" Nam tram");
                    break;

                case 6:
                    Console.Write(" Sau tram");
                    break;

                case 7:
                    Console.Write(" Bay tram");
                    break;

                case 8:
                    Console.Write(" Tam tram");
                    break;

                case 9:
                    Console.Write(" Chin tram");
                    break;

                case 0:
                    break;
            }

            switch (chuc)
            {
                case 1:
                    Console.Write(" muoi");
                    break;

                case 2:
                    Console.Write(" hai muoi");
                    break;

                case 3:
                    Console.Write(" ba muoi");
                    break;

                case 4:
                    Console.Write(" bon muoi");
                    break;

                case 5:
                    Console.Write(" nam muoi");
                    break;

                case 6:
                    Console.Write(" sau muoi");
                    break;

                case 7:
                    Console.Write(" bay muoi");
                    break;

                case 8:
                    Console.Write(" tam muoi");
                    break;

                case 9:
                    Console.Write(" chin muoi");
                    break;

                case 0:
                    if(tram != 0 && donVi != 0)
                    {
                        Console.Write(" linh");
                    }
                    break;
            }

            switch (donVi)
            {
                case 1:
                    if(chuc > 1)
                    {
                        Console.Write(" mot");   // mốt
                    }
                    else
                    {
                        Console.Write(" mot");   // một
                    }
                    break;

                case 2:
                    Console.Write(" hai");
                    break;

                case 3:
                    Console.Write(" ba");
                    break;

                case 4:
                    Console.Write(" bon");
                    break;

                case 5:
                    if(chuc != 0)
                    {
                        Console.Write(" lam");
                    }else
                    {
                        Console.Write(" nam");
                    }
                    break;

                case 6:
                    Console.Write(" sau");
                    break;

                case 7:
                    Console.Write(" bay");
                    break;

                case 8:
                    Console.Write(" tam");
                    break;

                case 9:
                    Console.Write(" chin");
                    break;

                case 0:
                    if (tram == 0 && chuc == 0)
                    {
                        Console.Write(" Khong");
                    }
                    break;
            }
        }
    }
}
