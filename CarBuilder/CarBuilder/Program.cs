using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarEngineer carEnginner = new CarEngineer();
            CarBuilder car = new Mazda626Builder();

            carEnginner.Construct(car);
            Car Mazda = car.getCar();

            Console.WriteLine("Car Maker: " + Mazda.getMaker());
            Console.WriteLine("Car Name: " + Mazda.getName());
            Console.WriteLine("Car Type: " + Mazda.getType());
            Console.ReadKey();
        }
    }
}
