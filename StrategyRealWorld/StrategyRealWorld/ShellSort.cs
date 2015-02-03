using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyRealWorld
{
    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }
}
