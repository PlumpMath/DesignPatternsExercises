﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyRealWorld
{
    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergSorted list ");
        }
    }
}
