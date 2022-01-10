using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
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

        public static bool operator ==(Vector a, Vector b)
        {

            if (a.X == b.X && a.Y == b.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Vector a, Vector b)
        {

            if (a.X != b.X && a.Y != b.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
