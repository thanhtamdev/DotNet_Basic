using System;

namespace Multicasting
{
    class HinhChuNhat
    {
        public void DienTich(double chieuDai, double chieuRong)
        {
            Console.WriteLine(" Dien tich HCN: " + (chieuDai * chieuRong));
        }

        public void ChuVi(double chieuDai, double chieuRong)
        {
            Console.WriteLine(" Chu vi HCN: " + (chieuDai + chieuRong) * 2);
        }
    }

    // 1. Khai báo delegate
    public delegate void MyDelegate(double a, double b);


    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            // 2. Khởi tạo delegates
            MyDelegate myDelegate = hcn.DienTich;
            myDelegate += hcn.ChuVi;    // Thêm 1 phương thức vào delegate

            // 3. Thực thi
            myDelegate(2, 3);

            myDelegate -= hcn.ChuVi;    // Bỏ đi 1 phương thức trong delegates

            myDelegate(2, 3);
        }
    }
}
