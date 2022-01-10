using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value
            // Key - là duy nhất
            // truy xuất phần tử thông qua key

            //1. Khai báo Hashtable
            Hashtable hashtable = new Hashtable();

            // Thêm phần tử
            hashtable.Add(1, 5);
            hashtable.Add(2, "Nam");
            hashtable.Add('B', 123.56);
            hashtable["cat"] = "Yellow";
            hashtable['C'] = 1235;
            // Xóa phần tử theo key
            hashtable.Remove(1);

            // Truy xuất phần tử
            // Cú pháp: tên_hashtable[key]
            Console.WriteLine(hashtable[2]);
            Console.WriteLine(hashtable["cat"]);

            // Duyệt các phần tử trong hashtable
            // Cách 1: Duyệt theo chiều dọc( lấy key -> value tương ứng)
            ICollection keys = hashtable.Keys;  // trả về 1 tập các key

            foreach (object item in keys)
            {
                Console.WriteLine(hashtable[item]);
            }

            // mỗi 1 hàng [key, value] là 1 entry
            // cách 2: Duyệt bằng cách lấy từng entry
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            // 4. Khởi tạo nhanh 1 hash table
            Hashtable hashTable = new Hashtable()
            {
                {1, "hoa" },
                {10, "Lan" },
                {'z', 10 },
                {'P', 1.235 }
            };

        }
    }
}
