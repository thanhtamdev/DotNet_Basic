using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();

            c.Input();

            Account[] a = new Account[c.Acc.Length + 1];
            Array.Copy(c.Acc, a, c.Acc.Length);

            a[c.Acc.Length] = new Account();

            Console.WriteLine("\n Nhap thong tin tai khoan can them: ");
            c.AddAccount(a[c.Acc.Length]);
            c.Acc = new Account[a.Length];
            Array.Copy(a, c.Acc, a.Length);
            c.Output();

            Console.Write("\n Nhap ten tai khoan can tim kiem thong tin: ");
            string s = Console.ReadLine();

            Account res = new Account();
            res = c.SearchAccount(s);

            if (String.IsNullOrEmpty(res.MaSoTK))
            {
                Console.WriteLine(" Tai khoan khong ton tai!");
            }
            else
            {
                Console.WriteLine(" Thong tin tai khoan " + s + ":");
                res.Output();
            }
        }
    }
}
