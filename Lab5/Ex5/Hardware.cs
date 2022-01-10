using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Hardware : Product
    {
        private double weight;

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public Hardware(string name, int price, double weight)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
        }
    }
}
