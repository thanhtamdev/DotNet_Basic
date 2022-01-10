using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] car = new Car[3];
            car[0] = new For();
            car[1] = new LandRover();
            car[2] = new Honda();

            foreach (var item in car)
            {
                item.Move();
            }
        }
    }
}
