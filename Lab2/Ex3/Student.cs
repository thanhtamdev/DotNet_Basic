using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Student
    {
        private string maSV;
        private string hoTen;
        private int namSinh;
        private string diaChi;

        public Student(string maSV, string hoTen, int namSinh, string diaChi)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.diaChi = diaChi;
        }

        public string MaSV
        {
            get
            {
                return maSV;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    maSV = value;
                }
                else
                {
                    Console.WriteLine("Ma sinh vien khong hop le!");
                }
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    hoTen = value;
                }
                else
                {
                    Console.WriteLine(" Ho ten khong hop le.");
                }
            }
        }

        public int NamSinh
        {
            get
            {
                return namSinh;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(" Nam sinh khong hop le!");
                }
                else
                {
                    namSinh = value;
                }
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
                if (!String.IsNullOrEmpty(value))
                {
                    diaChi = value;
                }
                else
                {
                    Console.WriteLine(" Dia chi khong hop le!");
                }
            }
        }
    }
}
