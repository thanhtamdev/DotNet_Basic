using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class NhanVien
    {
        protected string maNhanVien;
        protected string hoTen;
        protected DateTime ngaySinh;
        protected int soNgayLam;

        public string HoTen
        {
            get
            {
                return hoTen;
            }
        }

       public NhanVien()
        {
            Console.WriteLine(" Nhan vien");
        }

        public NhanVien(string maNhanVien, string hoTen)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
        }

        public NhanVien(string maNhanVien, string hoTen , DateTime ngaySinh, int soNgayLam)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.soNgayLam = soNgayLam;
        }

        public virtual int TinhLuong()
        {
            return soNgayLam * 10;
        }
    }
}
