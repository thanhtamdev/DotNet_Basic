using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("12345", "Nguyen Van A", 1999, "123 abc, xyz");

            Console.WriteLine(" Thong tin sinh vien: ");
            Console.WriteLine(" - Ma sinh vien: " + s.GetStudentCode());
            Console.WriteLine(" - Ho va ten: " + s.GetfullName());
            Console.WriteLine(" - Nam sinh: " + s.GetYearOfBirth());
            Console.WriteLine(" - Dia chi: " + s.GetAddress());
            Console.WriteLine();

            Console.WriteLine(" - Tuoi cua sinh vien: " + s.Age());
        }
    }
}
