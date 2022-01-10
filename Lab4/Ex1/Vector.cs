using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Vector
    {
        private double x;
        private double y;

        public Vector()
        {
            x = 0;
            y = 0;
        }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public static Vector operator +(Vector a, Vector b)
        {
            Vector res = new Vector();
            res.x = a.x + b.x;
            res.y = a.y + b.y;

            return res;
        }

        public static Vector operator -(Vector a, Vector b)
        {
            Vector res = new Vector();
            res.x = a.x - b.x;
            res.y = a.y - b.y;

            return res;
        }
    }
}
