using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine(" Nhap hai so a va b: ");
            try // Các lệnh có khả năng gây ra ngoại lệ -> đặt trong khối try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                Console.WriteLine(" c = " + c);
            }
            catch (FormatException ex1) // khi có ngoại lệ xảy ra, các lệnh trong khối catch sẽ đc thực thi 
            {

                Console.WriteLine(" Loi nhap lieu: " + ex1.Message);
            }
            catch (DivideByZeroException ex2)   // chồng catch
            {
                Console.WriteLine(" Loi chia cho 0: " + ex2.Message);
            }
            catch (Exception ex)    // catch này bắt tất cả các ngoại lệ
            {
                // chồng catch phải theo thứ tự lớp cha ở dưới lớp con
                Console.WriteLine(" Loi: " + ex.Message);
            }
            finally
            {
                // khối finally luôn đc thực hiện dù cho có hay không có ngoại lệ xảy ra
                Console.WriteLine(" Ket thuc chuong trinh.");
            }
        }
    }
}
