using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết chương trình chuyển ký tự hoa thành thường và ngược lại

            Console.Write(" Enter string: ");
            string str = Console.ReadLine();

            char[] a = str.ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                bool res = Char.IsUpper(a[i]);

                if (res)
                {
                    a[i] = Char.ToLower(a[i]);
                }
                else
                {
                    a[i] = Char.ToUpper(a[i]);
                }
            }

            string result = new string(a);

            Console.WriteLine(" Result: " + result);
        }
    }
}
