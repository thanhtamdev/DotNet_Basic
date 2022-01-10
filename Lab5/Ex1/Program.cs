using System;

namespace Ex123
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Nguyen Van A", "abc@gmail.com", "ID001");

            Console.WriteLine(" Thong tin sinh vien: ");
            Console.WriteLine(" - Ho va ten: " + s.Name);
            Console.WriteLine(" - Email: " + s.Email);
            Console.WriteLine(" - Student ID: " +s.StudentID);
        }
    }
}
