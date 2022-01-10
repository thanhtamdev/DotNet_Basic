using System;
using System.Collections;

namespace LearnArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Khai báo và khởi tạo ArrayList
            ArrayList arrayList = new ArrayList();

            // Bổ sung phần tử vào cuối ArrayList
            arrayList.Add(6);
            arrayList.Add("Hello");
            arrayList.Add('c');
            arrayList.Add(1.2453);
            arrayList.Add(6);

            //SinhVien sinhVien1 = new SinhVien("M01", "Nguyen Van A");
            //SinhVien sinhVien2 = new SinhVien("M02", "Le Van B");

            //arrayList.Add(sinhVien1);
            //arrayList.Add(sinhVien2);

            arrayList.Add(new SinhVien("M01", "Nguyen Van A"));
            arrayList.Add(new SinhVien("M02", "Le Van B"));

            //int[] arr = { 1, 2, 3 };

            //arrayList.AddRange(arr);

            // Chèn phần tử vào vị trí bất kì trong ArrayList
            //arrayList.Insert(2, "World!");

            // Chèn 1 mảng vào vị trí bất kì trong ArrayList
            //arrayList.InsertRange(3, arr);

            // Xóa các phần tử trong ArrayList
            //arrayList.Remove('c');
            //arrayList.RemoveAt(2);

            //2. Truy xuất phần tử của ArrayList
            // cú pháp: tên_arrayList[chỉ_số]
            // chỉ_số bắt đầu từ 0
            //Console.WriteLine(arrayList[5]);
            //arrayList[5] = "abc";
            //Console.WriteLine(arrayList[5]);

            // Tìm kiếm phần tử
            //arrayList.IndexOf("Hello");// trả về vị trí xuất hiện đầu tiên của Hello trong arrayList
            //arrayList.LastIndexOf(6);// trả về vị trí cuối cùng của số 6 trong arrayList

            // kiểm tra trong arrayList có phần tử nào có giá trị = 15 không
            // nếu có thì trả về true
            // không có trả về false
            //arrayList.Contains(15);

            //3. Duyệt arrayList
            // Cách 1: Sử dụng chỉ số để truy suất các giá trị trong arrayList
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.Write(arrayList[i] + "  ");
            //}

            // Cách 2: sử dụng phương thức GetEnumerator() - phương thức này trả về 1 tập hợp
            //IEnumerator e = arrayList.GetEnumerator();

            //while (e.MoveNext())
            //{
            //    Console.Write(e.Current + " ");
            //}

            // Cách 3: Sử dụng foreach
            // cái item phải có kiểu là object
            foreach (object item in arrayList)
            {
                if (item is SinhVien)
                {
                    SinhVien sv = (SinhVien)item;
                    sv.Xuat();
                }
                else
                {
                    Console.WriteLine(item);
                }
            }

            //4. Khởi tạo nhanh 1 arrayList
            //ArrayList arrayList1 = new ArrayList() { 1, 2, "Hello", 'C' };

            // Xóa toàn bộ arrayList
            //arrayList.Clear();
        }
    }
}
