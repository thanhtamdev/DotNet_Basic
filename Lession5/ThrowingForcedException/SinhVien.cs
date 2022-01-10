using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingForcedException
{
    class SinhVien
    {
        private string maSV;
        private string hoTen;
        private int tuoi; // tuoi >= 18

        // Phương thức nhập thông tin sinh viên
        public void NhapTTSV()
        {
            Console.Write(" Nhap ma sinh vien: ");
            maSV = Console.ReadLine();
            Console.Write(" Nhap ma ho ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.Write(" Nhap tuoi sinh vien: ");

            try
            {
                int x = Convert.ToInt32(Console.ReadLine());

                if (x < 18)
                {
                    // Tung ngoại lệ cưỡng bức
                    // throw new Exception("nội dung ngoại lệ.")
                    throw new Exception(" Tuoi phai lon hon hoac bang 18.");
                }
                else
                {
                    tuoi = x;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
