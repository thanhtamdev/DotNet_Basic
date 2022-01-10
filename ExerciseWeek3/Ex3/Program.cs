using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình nhập vào 1 chuỗi họ tên.
            // Chuẩn hóa chuỗi họ tên(không có khoảng trắng thừa, In hoa ký tự đầu tiên các từ)

            Console.Write(" Enter your first and last name: ");
            string fullName = Console.ReadLine();

            Console.WriteLine(" First and last name entered: \"" + fullName +"\"");

            fullName = fullName.Trim();

            while (fullName.IndexOf("  ") != -1)
            {
                fullName = fullName.Replace("  ", " ");
            }

            string[] subName = fullName.Split(' ');
            string result = "";

            for (int i = 0; i < subName.Length; i++)
            {
                string firstChar = subName[i].Substring(0, 1);
                string otherChar = subName[i].Substring(1);
                subName[i] = firstChar.ToUpper() + otherChar.ToLower();
                result += subName[i] + " ";
            }

            Console.WriteLine(" String after normalization: \"" + result + "\"");
        }
    }
}
