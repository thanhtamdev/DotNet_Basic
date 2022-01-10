using System;

namespace BuildClass
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            //hcn.SetChieuDai(8);
            //Console.WriteLine(hcn.GetChieuDai());

            // Truy cập thuộc tính thông qua property
            //hcn.ChieuDai = 8;
            //Console.WriteLine(hcn.ChieuDai);

            //Console.WriteLine(hcn.DienTich());  // 1

            //HinhChuNhat hcn1 = new HinhChuNhat(10, 5);

            //Console.WriteLine(hcn1.DienTich()); // 50

            //HinhChuNhat hcn2 = new HinhChuNhat(hcn1);

            //Console.WriteLine(hcn2.DienTich()); // 50

            HinhChuNhat hcn3 =new HinhChuNhat();
            hcn3 = hcn;
            hcn3.ChieuDai = 8;
            // Kiểu object đc lưu trữ trên hai vùng nhớ stack và heap
            // gán hai đối tượng obj2 = obj1 thì obj2 sẽ tham chiếu đến địa chỉ của obj1
            Console.WriteLine(" Chieu dai hcn 3: " + hcn3.ChieuDai);

            HinhChuNhat hcn5 = new HinhChuNhat(5, 6);
            HinhChuNhat hcn6 = new HinhChuNhat(5, 6);

            Console.WriteLine(hcn5 == hcn6);    //false

            // - Phép so sánh == của hai đối tượng:
            // so sánh hai đối tượng có tham chiếu đến cùng 1 vùng nhớ hay không?
            // - Để so sánh giá trị của hai đối tượng thì sử dụng phương thức Equals(nạp chồng phương thức)
            Console.WriteLine(hcn5.Equals(hcn6));   // true
        }
    }
}
