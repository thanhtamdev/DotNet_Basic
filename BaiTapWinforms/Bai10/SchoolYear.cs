using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class SchoolYear
    {

        private int year;

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public SchoolYear(int year)
        {
            this.year = year;
        }
    }
}
