using ClassGeneric;
using System;
using System.Collections.Generic;

namespace GenericCollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Khai báo
            // List<T> giống ArrayList nhưng phải chỉ định kiểu cho các phần tử
            List<string> list1 = new List<string>();

            // Thêm vào cuối danh sách
            list1.Add("Orange");
            list1.Add("Apple");
            list1.Add("Mango");

            list1[2] = "Banana";    // Thay thế giá trị của phần tử có chỉ số 2 thành Banana

            List<int> list2 = new List<int>();
            list2.Add(1);

            List<SinhVien> sinhViens = new List<SinhVien>();
            sinhViens.Add(new SinhVien("M01", "Le Van A"));
            sinhViens.Add(new SinhVien("M02", "Nguyen Van B"));

            foreach (SinhVien item in sinhViens)
            {
                item.Xuat();
            }

            // 2. Truy xuất phần tử trong List<T>
            // cú pháp: tên_list[chỉ_số]
            // chỉ số bắt đầu từ 0

            Console.WriteLine(list1[2]);

            // 3. Xác định số lượng phân tử trong list
            Console.WriteLine(list1.Count);

            // 4. Một số phương thức thường dùng
            list1.Sort();   // Sắp xếp các phần tử

            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }

            list1.Insert(1, "Lemon"); // Chèn 1 phần tử vào vị trí 1 có giá tị Lemon
            int res = list1.IndexOf("Lemon"); // Trả về vị trí của phần tử có giá trị Lemon trong list1

            Console.WriteLine(res);

            // xóa theo chỉ số
            list1.RemoveAt(0);
            // Xóa giá trị: Remove
            // Xóa toàn bộ RemoveAll
            // Xóa 1 vùng nào đó: RemoveRange
            // Đảo ngược list: Revert

            // 5. Duyệt các phần tử trong List
            // Cách 1: Duyệt theo chỉ số
            for (int i = 0; i < list1.Count; i++)
            {
                Console.Write(list1[i] + "\t");
            }

            // Cách 2: Sử dụng foreach
            foreach (string item in list1)
            {
                Console.Write(item + "\t");
            }


        }
    }
}
