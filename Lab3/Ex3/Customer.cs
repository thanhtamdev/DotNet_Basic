using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Customer
    {
        private string maKH;
        private string id;
        private string diaChi;
        private Account[] acc;

        public Customer()
        {
            maKH = "";
            id = "";
            diaChi = "";
            acc = new Account[0];
        }

        public Customer(string maKH)
        {
            this.maKH = maKH;
        }

        public string MaKH
        {
            get
            {
                return maKH;
            }
            set
            {
                maKH = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }

        public Account[] Acc
        {
            get
            {
                return acc;
            }

            set
            {
                acc = value;
            }
        }

        public void Input()
        {
            Console.Write(" Nhap ma khach hang: ");
            maKH = Console.ReadLine().ToUpper();
            Console.Write(" Nhap so chung minh thu: ");
            id = Console.ReadLine();
            Console.Write(" Nhap dia chi: ");
            diaChi = Console.ReadLine();
        }

        public void AddAcount(Account account)
        {
            account.Input();
        }

        //public Account SearchAccount(string mtk, Account[] a)
        //{
        //    Account kq = new Account();

        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (String.Compare(mtk, acc[i].MaSoTK) == 0)
        //        {
        //            kq = a[i];
        //        }
        //    }

        //    return kq;
        //}

        public void Output()
        {
            Console.WriteLine("\n Thong tin khach hang: ");
            Console.WriteLine(" - Ma khach hang: " + maKH);
            Console.WriteLine(" - So chung minh thu: " + id);
            Console.WriteLine(" - Dia chi: " + diaChi);
            Console.WriteLine(" Thong tin cac tai khoan: ");

            foreach (var item in acc)
            {
                item.Output();
            }
        }
    }
}
