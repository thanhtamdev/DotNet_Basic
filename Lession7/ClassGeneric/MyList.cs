using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneric
{
    class MyList<T> //where T:struct    // Thêm các ràng buộc kiểu dữ liệu cho T
    {
        // Khai báo thuộc tính
        private T[] data;

        // Phương thức khởi tạo
        public MyList(int n)
        {
            data = new T[n];
        }

        // Trả về độ dài của danh sách
        public int Size()
        {
            return data.Length;
        }

        // Phương thức thêm phần tử
        public void Set(int index, T value)
        {
            if (index >= 0 && index < data.Length)
            {
                data[index] = value;
            }
        }

        // Phương thức lấy phần tử
        public T Get(int index)
        {
            if (index >= 0 && index < data.Length)
            {
                return data[index];
            }

            return default(T);
        }
    }
}
