using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                try
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new PersonException("First name is empty");
                    }
                    else
                    {
                        firstName = value;
                    }
                }
                catch (PersonException pe)
                {
                    Console.WriteLine(" Loi: " + pe.Message);
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                try
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new PersonException("Last name is empty");
                    }
                    else
                    {
                        lastName = value;
                    }
                }
                catch (PersonException pe)
                {
                    Console.WriteLine(" Loi: " + pe.Message);
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                try
                {
                    if (value < 0 || value > 120)
                    {
                        throw new PersonException("Invalid age!");
                    }
                    else
                    {
                        age = value;
                    }
                }
                catch (PersonException pe)
                {
                    Console.WriteLine(" Loi: " + pe.Message);
                }
            }
        }

    }
}
