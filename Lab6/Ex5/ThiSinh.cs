using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class ThiSinh
    {
        protected string sbd;
        protected string hoTen;
        protected double bai1;
        protected double bai2;
        protected double bai3;
        protected double tongDiem;

        public string SBD
        {
            get
            {
                return sbd;
            }

            set
            {
                sbd = value;
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
                hoTen = value;
            }
        }

        public double Bai1
        {
            get
            {
                return bai1;
            }

            set
            {
                bai1 = value;
            }

        }

        public double Bai2
        {
            get
            {
                return bai2;
            }

            set
            {
                bai2 = value;
            }

        }

        public double Bai3
        {
            get
            {
                return bai3;
            }

            set
            {
                bai3 = value;
            }

        }

        public double TongDiem
        {
            get
            {
                return tongDiem;
            }

            set
            {
                tongDiem = value;
            }

        }

        public virtual void NhapTTTS()
        {
            Console.Write(" Nhap so bao danh: ");
            sbd = Console.ReadLine();
            Console.Write(" Nhap ho ten thi sinh: ");
            hoTen = Console.ReadLine();
            Console.Write(" Nhap diem bai thi thu nhat: ");
            bai1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Nhap diem bai thi thu hai: ");
            bai2 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Nhap diem bai thi thu ba: ");
            bai3 = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void InTTTS()
        {
            Console.WriteLine("\n Thong tin thi sinh: ");
            Console.WriteLine(" So bao danh: " + sbd);
            Console.WriteLine(" Ho ten: " + hoTen);
            Console.WriteLine(" Diem thi bai 1: " + bai1);
            Console.WriteLine(" Diem thi bai 2: " + bai2);
            Console.WriteLine(" Diem thi bai 3: " + bai3);
        }

        public virtual double TinhTongDiem()
        {
            tongDiem = bai1 + bai2 + bai3;
            return tongDiem;
        }

    }
}
