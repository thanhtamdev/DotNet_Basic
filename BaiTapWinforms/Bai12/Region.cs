using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    class Region
    {
        private string regionName;
        private int quota;

        public string RegionName
        {
            get
            {
                return regionName;
            }

            set
            {
                regionName = value;
            }
        }

        public int Quota {
            get
            {
                return quota;
            }

            set
            {
                quota = value;
            }
        }

        public Region(string regionName, int quota)
        {
            this.regionName = regionName;
            this.quota = quota;
        }
    }
}
