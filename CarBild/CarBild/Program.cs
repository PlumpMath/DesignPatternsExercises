using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarBild
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleEngineer vEnginner = new VehicleEngineer();
            VehicleBuilder mazdaBuilder = new ConcretVehicleBuilder();
            vEnginner.Construct(mazdaBuilder);
            Vehicle mazdaVehicle = mazdaBuilder.getVehicle();

            mazdaVehicle.Show();
            Console.ReadKey();
            
        }
    }
}
