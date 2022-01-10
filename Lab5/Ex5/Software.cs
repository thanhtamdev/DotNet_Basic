using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Software : Product
    {
        private string version;

        public string Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
            }
        }

        public Software(string name, int price, string version)
        {
            this.name = name;
            this.price = price;
            this.version = version;
        }
    }
}
