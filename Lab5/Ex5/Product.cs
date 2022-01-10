using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Product
    {
        protected string name;
        protected int price;

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

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public Product() { }
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
