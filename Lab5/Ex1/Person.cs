using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex123
{
    class Person
    {
        protected string name;
        protected string email;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public Person()
        {
            this.name = "";
            this.email = "";
        }

        public Person(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
    }
}
