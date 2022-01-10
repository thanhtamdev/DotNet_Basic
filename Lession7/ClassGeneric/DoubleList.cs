using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneric
{
    class DoubleList
    {
        // Khai báo thuộc tính
        private double[] data;

        // Phương thức khởi tạo
        public DoubleList(int n)
        {
            data = new double[n];
        }

        // Trả về độ dài của danh sách
        public int Size()
        {
            return data.Length;
        }

        // Phương thức thêm phần tử
        public void Set(int index, double value)
        {
            if (index >= 0 && index < data.Length)
            {
                data[index] = value;
            }
        }

        // Phương thức lấy phần tử
        public double Get(int index)
        {
            if (index >= 0 && index < data.Length)
            {
                return data[index];
            }

            return -1.0;
        }
    }
}
