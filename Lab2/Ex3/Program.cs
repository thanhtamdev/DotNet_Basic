using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("MS001", "Nguyen Van A", 1999, "abc, xyz");

            Console.WriteLine(" Thong tin sinh vien: ");
            Console.WriteLine(" - Ma sinh vien: " + student.MaSV);
            Console.WriteLine(" - Ho va ten: " + student.HoTen);
            Console.WriteLine(" - Nam sinh: " + student.NamSinh);
            Console.WriteLine(" - Dia chi: " + student.DiaChi);


        }
    }
}
