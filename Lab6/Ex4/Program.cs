using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.Write(" Nhap so luong nhan vien: n = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            Employee[] e = new Employee[n];

            NhapDSNV(e);
            HienThiTT(e);
        }

        private static void NhapDSNV(Employee[] e)
        {
            for (int i = 0; i < e.Length; i++)
            {
                Console.WriteLine("\n Nhap thong tin nhan vien thu: " + (i + 1));

                string val = "";

                Console.Write(" Bo phan (Progammer - ‘P’, Tester ‘T’): ");
                val = Console.ReadLine().ToLower();

                if (String.Compare(val, "p") == 0)
                {
                    e[i] = new Programmer();
                    e[i].NhapTTNV();
                }
                else
                {
                    e[i] = new Tester();
                    e[i].NhapTTNV();
                }
            }
        }

        private static void HienThiTT(Employee[] e)
        {
            Console.WriteLine("\n Luong cua cac nhan vien: ");

            foreach (var item in e)
            {
                item.InTTNV();
            }
        }
    }
}