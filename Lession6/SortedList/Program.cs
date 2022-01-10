using System;
using System.Collections;

namespace SortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Giống với Hashtable, nhưng khác với Hastable:
            // + Các phần tử được tự động sắp xếp tăng dần theo key
            // + SortedList có thể truy xuất các phần tử theo key hoặc theo chỉ số

            // 1. Khai báo và khởi tạo:
            SortedList sortedList = new SortedList();

            // Thêm phần tử:
            sortedList.Add(6, 2);
            sortedList.Add(2, 5);
            sortedList.Add(3, "abc");

            // Truy xuất phần tử trong sortedlist 
            //Console.WriteLine(sortedList[2]);   // Lấy value có key bằng 2
            //Console.WriteLine(sortedList.GetKey(0));    // Lấy key theo chỉ số
            //Console.WriteLine(sortedList.GetByIndex(3)); // Lấy key theo giá trị 

            // Các phương thức thường sử dụng
            sortedList.Add(5, 3);   // Thêm 
            //sortedList.Remove(3);   // Xóa phần tửu có key = 3
            //sortedList.RemoveAt(0); // Xóa phần tử có chỉ số là 0

            //Console.WriteLine(sortedList.IndexOfKey(10));   // Tìm kiếm vị trí của key = 10 trong sorted list
            //Console.WriteLine(sortedList.IndexOfValue('a'));

            // Duyệt các phần tử 
            // cách 1: Duyệt theo chiều dọc
            ICollection keys = sortedList.Keys;

            foreach (object key in keys)
            {
                Console.WriteLine(key + "\t" + sortedList[key]);
            }

            // Cách 2: duyệt theo chiều ngang
            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine(entry.Key + "\t" + entry.Value);
            }

            // Cách 3: duyệt theo chỉ số
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList.GetKey(i) + "\t" + sortedList.GetByIndex(i));
            }
        }
    }
}
