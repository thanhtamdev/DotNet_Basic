using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập vào họ tên và in ra tên
            //Console.Write(" Nhap ho va ten: ");
            //string fullName = Console.ReadLine();

            // cách 1:
            //int index = fullName.LastIndexOf(' ');
            //string name = fullName.Substring(index + 1);

            //Console.WriteLine(name);

            // cách 2:
            //string[] arrayWord = fullName.Split(' ');
            //string Name = arrayWord[arrayWord.Length - 1];

            //Console.WriteLine(Name);


            // Ví dụ 2: Nhập họ tên và in hoa các kí tự đầu của các từ,
            // và các chữ còn lại của từ thì viết thường
            //string s = fullName.ToLower();
            //char[] charArr = s.ToCharArray();

            //charArr[0] = char.ToUpper(charArr[0]);

            //for (int i = 1; i < charArr.Length; i++)
            //{
            //    if(charArr[i] == ' ')
            //    {
            //        charArr[i + 1] = char.ToUpper(charArr[i + 1]);
            //    }
            //}

            //string res = new string(charArr);

            //Console.WriteLine(res);

            // ví dụ 3:
            // viết chương trình chuyển chữ hoa thành chữ thường và chữ thường -> chữ hoa trong họ tên

            Console.Write(" Nhap chuoi ki tu: ");
            string s = Console.ReadLine();

            //char[] arr = s.Split
        }
    }
}
