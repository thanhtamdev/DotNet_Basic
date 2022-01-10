using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
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

        public static Vector operator +(double k, Vector a)
        {
            Vector res = new Vector();
            res.X = k + a.X;
            res.Y = k + a.Y;

            return res;
        }

        public static Vector operator +(Vector a, double k)
        {
            Vector res = new Vector();
            res.X = a.X + k;
            res.Y = a.Y + k;

            return res;
        }
    }
}
