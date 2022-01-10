using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NhapSKH();  // Nhập số lượng khách hàng

            Customer[] c = new Customer[n]; // Mảng khách hàng
            int m = 0;  // Số lượng tài khoản của 1 khách hàng
            int sl = 0; // số lượng các giá trị được thêm vào mảng sltk
            int[,] sltk = new int[100, 100];    // Mảng số lượng tài khoản
            Account[,] a = new Account[100, 100];   // Mảng tài khoản

            NhapDSKH(c, a, ref m, sltk, ref sl);    // Nhập vào danh sách khách hàng 
            //XuatDSKH(c, a, sltk, sl);  // In danh sách vừa nhập ra

            //Console.Write(" Nhap so thu tu cua tai khoan: ");
            //int stt = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < c.Length; i++)
            //{
            //    if (i + 1 == stt)
            //    {
            //        m++;

            //        for (int j = 0; j < m; j++)
            //        {
            //            sltk[i, j] = m;

            //            if (j == m - 1)
            //            {
            //                a[i, j] = new Account();
            //                c[i].AddAcount(a[i, j]);
            //            }
            //        }
            //    }
            //}

            //for (int i = 0; i < c.Length; i++)
            //{
            //    if (i + 1 == stt)
            //    {
            //        c[i].Output();

            //        //for (int k = 0; k < m; k++)
            //        //{
            //        //    a[i, k].Output();
            //        //}

            //        for (int j = 0; j < sl; j++)
            //        {
            //            if (sltk[i, j] == m)
            //            {
            //                for (int k = 0; k < sltk[i, j]; k++)
            //                {
            //                    a[i, k].Output();
            //                }
            //            }

            //        }
            //    }
            //}

            Console.WriteLine(" Nhap ma so tai khoan can kiem tra: ");
            string maTK = Console.ReadLine();

            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < sl; j++)
                {
                    for (int k = 0; k < sltk[i, j]; k++)
                    {
                        if (String.Compare(a[i, k].MaSoTK, maTK) == 0)
                        {
                            c[i].Output();
                            a[i, k].Output();
                        }
                    }
                }
            }
        }

        // Nhập số lượng khách hàng cần nhập thông tin
        private static int NhapSKH()
        {
            int n = 0;

            do
            {
                Console.Write(" Nhap so luong khach hang can nhap thong tin: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            return n;
        }

        // Nhập vào danh sách khách hàng 
        private static void NhapDSKH(Customer[] c, Account[,] a, ref int m, int[,] sltk, ref int sl)
        {
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(" Nhap thong tin khach hang thu " + (i + 1));
                c[i] = new Customer();
                c[i].Input();

                Console.Write(" Nhap so luong tai khoan: ");
                m = Convert.ToInt32(Console.ReadLine());

                sltk[i, sl] = m;
                sl++;

                for (int j = 0; j < m; j++)
                {
                    a[i, j] = new Account();
                    a[i, j].Input();
                }
            }
        }

        // In danh sách vừa nhập ra
        private static void XuatDSKH(Customer[] c, Account[,] a, int[,] sltk, int sl)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Output();

                for (int j = 0; j < sl; j++)
                {
                    for (int k = 0; k < sltk[i, j]; k++)
                    {
                        a[i, k].Output();
                    }
                }
            }
        }
    }
}
