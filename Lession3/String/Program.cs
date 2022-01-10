using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Khai báo chuỗi
            // cách 1: string tên_biến = new string(char[] array)

            char[] s = new char[] { 'a', 'b' };
            //string s1 = new string(new char[] { 'a', 'b' });
            string s1 = new string(s);

            // cách 2: string tên_biến = "giá_trị"
            string str = "Hello world!";
            string str1 = "abc";

            // các thuộc tính và phương thức thường sử dụng

            // lấy độ dài của chuỗi str
            int a = str.Length;

            Console.WriteLine(a);   //12

            // phương thức chuyển chuỗi sang chữ in hoa, in thường
            Console.WriteLine(str.ToLower());   // chuyển chuỗi str sang chữ thường
            Console.WriteLine(str.ToUpper());   // chuyển chuỗi str sang chữ hoa

            // phương thức so sánh hai chuỗi: s1.CompareTo(s2)
            // nếu == 0 thì hai chuỗi bằng nhau, khác 0 thì hai chuỗi ko giống nhau
            Console.WriteLine(str.CompareTo(str1));

            // Chuyển một chuỗi sang mảng kí tự: ToCharArray()
            char[] charArray = str1.ToCharArray();
            Console.WriteLine(charArray[1]);

            // Tìm vị trí xuất hiện đầu tiên của chuỗi str trong chuỗi s: s.IndexOf(str)
            string s3 = "xin xin chao tat ca moi nguoi va tat ca cac ban.";
            Console.WriteLine(s3.IndexOf("xin"));

            // Phương thức s.LastIndexOf(str): trả về vị trí xuất hiện cuối cùng của chuỗi str
            // trong chuỗi s
            Console.WriteLine(s3.LastIndexOf("ca"));

            // Cắt chuỗi con: s.SubString(index, lenght)
            // cắt chuỗi con từ chuỗi con có độ dài lenght từ chuỗi s tại vị trí index
            // lenght có thể có hoặc ko.
            // nếu ko truyền length thì nó sẽ cắt từ index đến cuối chuỗi

            Console.WriteLine(s3.Substring(5, 8));
            Console.WriteLine(s3.Substring(8));

            // s.Replace(string old, string new): thay thế chuỗi cũ bằng chuỗi mới trong chuỗi s
            string s5 = "Hello world!";
            Console.WriteLine(s5.Replace("world", "World"));

            // Phương thức s.Split(regex):
            // chia chuỗi s thành mảng các chuỗi con dựa vào kí tự phân cách regex

            string[] stringArr = s5.Split(' ');

            Console.WriteLine(stringArr[1]);

            // Loại bỏ các khoảng trắng thừa ở hai đầu chuỗi s: s.Trim(): 
            string s6 = "   Hello World!   ";
            Console.WriteLine(s6.Trim());

            // s.Insert(index, value): chèn chuỗi value vào chuỗi s tại vị trí index
            string s7 = "Hello, ";
            Console.WriteLine(s7.Insert(7, "world!"));

            // s.Remove(index, count): xóa count kí tự của s tính từ vị trí index
            Console.WriteLine(s6.Remove(0, 2));

            // s.Contains(str): kiểm tra chuỗi str có xuất hiện trong s hay không
            // nếu có trả về true và ngược lại là false
            Console.WriteLine(s5.Contains("Hello"));

            // s.StartsWith(str): Kiểm tra chuỗi s có bắt đầu bằng chuỗi str hay không?
            Console.WriteLine(s5.StartsWith("abc"));
        }
    }
}