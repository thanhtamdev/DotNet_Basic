using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Student
    {
        private string studentCode;
        private string fullName;
        private int yearOfBirth;
        private string address;

        // Constructor
        public Student(string id, string name)
        {
            studentCode = id;
            fullName = name;
        }

        public Student(string id, string name, int year, string add)
        {
            studentCode = id;
            fullName = name;
            yearOfBirth = year;
            address = add;
        }

        // Set. Get studentCode
        public void SetStudentCode(string id)
        {
            studentCode = id;
        }

        public String GetStudentCode()
        {
            return studentCode;
        }

        // Set, Get fullName
        public void SetfullName(String name)
        {
            fullName = name;
        }

        public String GetfullName()
        {
            return fullName;
        }

        // Set, Get yearOfBirth
        public void SetYearOfBirth(int year)
        {
            yearOfBirth = year;
        }

        public int GetYearOfBirth()
        {
            return yearOfBirth;
        }

        // Set, Get address
        public void SetAddress(String add)
        {
            address = add;
        }

        public String GetAddress()
        {
            return address;
        }

        // age
        public int Age()
        {
            return DateTime.Now.Year - yearOfBirth;
        }
    }
}
