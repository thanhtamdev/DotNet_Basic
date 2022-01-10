using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();

            c.OutPutCircle();

            c.InputRadius();
            c.OutPutCircle();
            c.Perimeter();
            c.Area();
            
        }
    }
}
