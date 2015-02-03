using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterRealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            Compound water = new RichCompound("Water");
            water.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            Compound benzine = new RichCompound("Benzine");
            benzine.Display();

            Console.ReadKey();
        }
    }
}
