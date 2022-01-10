using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(12345, 100_000);

            Console.WriteLine(" Thong tin tai khoan truoc khi cap nhat: ");
            Console.WriteLine(" - Ma so tai khoan: " + acc.GetAccountNumber());
            Console.WriteLine(" - So tien: " + acc.GetAmountOfMoney());

            acc.SetAccountNumber(123456);
            acc.SetAmountOfNumber(500_000);

            Console.WriteLine();
            Console.WriteLine(" Thong tin tai khoan sau khi cap nhat: ");
            Console.WriteLine(" - Ma so tai khoan: " + acc.GetAccountNumber());
            Console.WriteLine(" - So tien: " + acc.GetAmountOfMoney());
        }
    }
}