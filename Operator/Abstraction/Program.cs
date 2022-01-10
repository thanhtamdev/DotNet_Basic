using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết phương thức tính cước
            // 1. Viết tại hai lớp: KHTraTheoDL và KHTraTronGoi -> mất tính đa hình
            // 2. Viết ở cả 3 lớp KhachHang, KHTraTheoDL, KHTraTronGoi
            // -> Phương thức tính cước ở lớp khách hàng k viết đc
            // -> cần phải xây dựng 1 phương thức trừu tượng(abstract method)
            // - Một lớp chứa 1 phương thức trừu tượng thì lớp đó phải là lớp trừu tượng
            // sử dụng từ khóa abstract
            // Lớp mà kế thừa từ lớp trừu tượng phải cài đặt đầy đủ phương thức trừu tượng của lớp cha

            // KHÔNG KHỞI TẠO ĐƯỢC ĐỐI TƯỢNG TỪ LỚP TRỪU TƯỢNG
            //KhachHang a = new KhachHang("003", "Bob");
            KhachHang[] arrKH = new KhachHang[2];
            arrKH[0] = new KHTraTheoDL("001", "Tim", 10000);
            arrKH[1] = new KHTraTronGoi("002", "Jimmy");

            for (int i = 0; i < arrKH.Length; i++)
            {
                Console.WriteLine(arrKH[i].HoTen + " Cuoc phi: " + arrKH[i].TinhCuoc());

            }
        }
    }
}
