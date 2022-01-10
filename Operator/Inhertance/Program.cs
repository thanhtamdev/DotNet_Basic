using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //NhanVienBH nvbh = new NhanVienBH();

            //Children children = new Children();

            NhanVien[] arrNV = new NhanVien[2];
            arrNV[0] = new NhanVien("001", "John", Convert.ToDateTime("01/10/1999"), 25);
            arrNV[1] = new NhanVienBH("002", "May", Convert.ToDateTime("12/05/2000"), 20, 10);

            for (int i = 0; i < arrNV.Length; i++)
            {
                Console.WriteLine(arrNV[i].HoTen + " luong: " + arrNV[i].TinhLuong());
            }
        }
    }
}
