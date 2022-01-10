using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildClass
{
    class HinhChuNhat
    {
        // Khai báo thuộc tính
        // Nếu để public thì sẽ mất đi tính đóng gói
        // private/ protected: sử dụng phương thức Get, Set hoặc property
        private int chieuDai;
        private int chieuRong;

        // Phương phức khởi tạo: 
        // - Có tên trùng với tên class
        public HinhChuNhat()
        {
            chieuRong = 1;
            chieuDai = 1;
        }

        public HinhChuNhat(int a, int b)
        {
            chieuDai = a;
            chieuRong = b;
        }

        // Phương thức khởi tạo sao chép
        public HinhChuNhat(HinhChuNhat h)
        {
            chieuDai = h.chieuDai;
            chieuRong = h.chieuRong;
        }

        //public int GetChieuDai()
        //{
        //    return chieuDai;
        //}

        //public void SetChieuDai(int d)
        //{
        //    chieuDai = d;
        //}

        // Khai báo property
        public int ChieuDai
        {
            get // Lấy thuộc tính ra
            {
                return chieuDai;
            }

            set    // Đặt dữ liệu cho thuộc tính
            {
                chieuDai = value;
            }
        }

        public int ChieuRong
        {
            get
            {
                return chieuRong;
            }

            set
            {
                chieuRong = value;
            }
        }

        // Khai báo phương thức
        public int ChuVi()
        {
            return (chieuDai + chieuRong) * 2;
        }

        public int DienTich()
        {
            return chieuDai * chieuRong;
        }

        public override bool Equals(object obj)
        {
            HinhChuNhat hcn = (HinhChuNhat)obj;

            if (chieuDai == hcn.chieuDai && chieuRong == hcn.chieuRong)
            {
                return true;
            }

            return false;
        }
    }
}
