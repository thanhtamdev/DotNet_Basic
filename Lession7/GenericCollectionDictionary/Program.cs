using System;
using System.Collections.Generic;

namespace GenericCollectionDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<T> tương tự Hashtable nhưng phải khai báo kiểu dữ liệu cho các phần tử
            // T là cặp <key, value>

            // 1. Khai báo và khởi tạo: 
            Dictionary<int, string> dic = new Dictionary<int, string>();

            // Thêm phần tử vào Dictionary<T>
            dic.Add(1, "One");
            dic.Add(2, "Two");
            dic.Add(5, "Five");
            dic.Add(15, "Fifteen");

            // 2. Truy xuất phần tử:
            // truy xuất theo chỉ số key: tên_dictionart[key];
            Console.WriteLine(dic[5]);

            // 3. Các phương thức thường sử dụng
            dic.Remove(15); // Xóa phần tử theo key
            dic.ContainsKey(2); // kiểm tra trong dictionary có phần tử nào có key = 2 hay không?
            dic.ContainsValue("Ten");   // Kiểm tra trong dictionary có phần tử nào có value = Ten không?

            // 4. Duyệt phần tử
            // Cách 1: lấy tập các key sau đó lấy value tương ứng với key đó
            ICollection<int> keys = dic.Keys;

            foreach (int item in keys)
            {
                Console.WriteLine(item + "\t" + dic[item]);
            }

            Console.WriteLine();

            // Cách 2: 
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            // SortedList<T> tương tự như sortedlist 
            // Các collection khác tương tự, tự tìm hiểu

        }
    }
}
