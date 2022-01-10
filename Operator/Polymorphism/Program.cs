using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //LopCon con = new LopCon();

            //con.RutTien(10);

            LopCha a = new LopCon();// upcasting

            LopCon b = (LopCon)a;   // downcasting
        }
    }
}
