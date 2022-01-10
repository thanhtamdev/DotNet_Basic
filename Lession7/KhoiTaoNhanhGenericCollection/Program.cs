using System;
using System.Collections.Generic;

namespace KhoiTaoNhanhGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listString = new List<string>();

            listString.Add("One");
            listString.Add("Two");
            listString.Add("Three");
            listString.Add("Four");
            listString.Add("Five");

            // Có thể viết lại:
            List<string> list1 = new List<string>()
            {
                "One", "Two", "Three",
                "Four", "Five"
            };

            // SortedList
            Dictionary<int, char> dic = new Dictionary<int, char>();
            dic.Add(1, 'a');
            dic.Add(2, 'b');
            dic.Add(3, 'c');
            dic.Add(4, 'd');
            dic.Add(5, 'e');

            Dictionary<int, char> dic1 = new Dictionary<int, char>()
            {
                {1, 'a' }, {2, 'b'},
                {3, 'c' }, {4, 'd'},
                {5, 'e' }
            };

            //List<KhachHang> listKH = new List<KhachHang>();
            KhachHang kh1 = new KhachHang("M01", "Nguyen Van A");
            KhachHang kh2 = new KhachHang("M02", "Nguyen Van B");
            KhachHang kh3 = new KhachHang("M03", "Nguyen Van C");

            //listKH.Add(kh1);

            // Có thể viết gọn
            List<KhachHang> listKH = new List<KhachHang>()
            {
                new KhachHang("M01", "Nguyen Van A"),
                new KhachHang("M02", "Tran Van B"),
                new KhachHang("M03", "Le Van C")
            };

            SortedList<string, KhachHang> list5 = new SortedList<string, KhachHang>()
            {
                {"M01", new KhachHang("M1", "Nguyen Van A") },
                {"M02", new KhachHang("M2", "Pham Van A") },
                {"M03", new KhachHang("M3", "Dinh Van A") }
            };
        }
    }
}
