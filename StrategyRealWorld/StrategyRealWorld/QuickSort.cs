using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyRealWorld
{
    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("QuickSorted list ");
        }
    }
}
