using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex123
{
    class Student : Person
    {
        private string studentID;

        public string StudentID
        {
            get
            {
                return studentID;
            }

            set
            {
                studentID = value;
            }
        }

        //Default constructor
        //public Student()
        //{
        //    studentID = "";
        //}

        public Student():base("Nguyen Van A", "abc@gamil.com")
        {
            studentID = "";
        }

        public Student(string name, string email, string studentID)
        {
            this.name = name;
            this.email = email;
            this.studentID = studentID;
        }

    }
}
