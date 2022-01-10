using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnArrayList
{
    class SinhVien
    {
        private string maSV;
        private string hoTen;

        public string MaSV
        {
            get { return maSV; }
        }

        public string HoTen
        {
            get { return hoTen; }
        }

        public SinhVien(string maSV, string hoTen)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
        }

        public void Xuat()
        {
            Console.WriteLine(maSV + "\t" + hoTen);
        }
    }
}
