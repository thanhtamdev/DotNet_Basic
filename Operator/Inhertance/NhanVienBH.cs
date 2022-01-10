using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class NhanVienBH: NhanVien
    {
        private int soSP;

        // Phương thức khỏi tạo lớp con luôn gọi phương thức khởi tạo của lớp cha
        // có hai cách gọi:
        // + Gọi tường minh: Khi lớp cha không có method default constructor
        //                  Gọi tường minh thông qua từ khóa base
        // Gọi không tường minh: khi lớp cha có method default constructor 


        // Nếu viết ko có từ khóa base thì nó sẽ gọi tới default constructor của lớp cha
        public NhanVienBH()
        {
            Console.WriteLine(" Nhan vien ban hang");
        }


        // Nếu viết thì nó sẽ gọi tới constructor hai tham số của lớp cha
        //public NhanVienBH(): base("001", "Tam")
        //{
        //    Console.WriteLine(" Nhan vien ban hang");
        //}

        public NhanVienBH(string maNhanVien, string hoTen, DateTime ngaySinh, int soNgayLam, int soSP)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.soNgayLam = soNgayLam;
            this.soSP = soSP;
        }

        public override int TinhLuong()
        {
            return soNgayLam * 5 + soSP * 2;
        }
    }
}
