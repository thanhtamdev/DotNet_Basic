using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneric
{
    class IntList
    {
        // Khai báo thuộc tính
        private int[] data;

        // Phương thức khởi tạo
        public IntList(int n)
        {
            data = new int[n];
        }

        // Trả về độ dài của danh sách
        public int Size()
        {
            return data.Length;
        }

        // Phương thức thêm phần tử
        public void Set(int index, int value)
        {
            if (index >= 0 && index < data.Length)
            {
                data[index] = value;
            }
        }

        // Phương thức lấy phần tử
        public int Get(int index)
        {
            if (index >= 0 && index < data.Length)
            {
                return data[index];
            }

            return -1;
        }
    }
}
