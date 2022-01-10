using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Book
    {
        private string tenSach;
        private int giaSach;
        private int giamGia;

        public Book(string tenSach, int giaSach, int giamGia)
        {
            if (String.IsNullOrEmpty(tenSach) || giaSach < 0 || giamGia < 0)
            {
                Console.WriteLine(" Du lieu khong hop le!");
                
                this.tenSach = default;
                this.giaSach = default;
                this.giamGia = default;
            }
            else
            {
                this.tenSach = tenSach;
                this.giaSach = giaSach;
                this.giamGia = giamGia;
            }
        }

        public string TenSach
        {
            get
            {
                return tenSach;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    tenSach = value;
                }
                else
                {
                    Console.WriteLine(" Ten sach khong duoc de trong.");
                }
            }
        }

        public int GiaSach
        {
            get
            {
                return giaSach;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine(" Gia sach phai >= 0.");
                }
                else
                {
                    giaSach = value;
                }
            }
        }

        public int GiamGia
        {
            get
            {
                return giamGia;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine(" Gia giam phai >= 0.");
                }
                else
                {
                    giamGia = value;
                }
            }
        }
    }
}
