using System;

namespace SelfDefineException
{
    class Program
    {
        static void Main(string[] args)
        {
            KhachHang kh = new KhachHang();

            kh.HoTen = "Nguyen Van A";
            kh.Tuoi = 25;

            Console.WriteLine(" Thong tin khach hang: ");
            Console.WriteLine(" - Ho ten: " + kh.HoTen);
            Console.WriteLine(" - Tuoi: " + kh.Tuoi);
        }
    }
}
