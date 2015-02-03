using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Context context;
            List<Context> context = new List<Context>();
            context.Add(new Context(new ConcreteStrategyA()));
            context.Add(new Context(new ConcreteStrategyB()));
            context.Add(new Context(new ConcreteStrategyC()));
          
            foreach (var element in context)
            {
                element.ContextInterface();
            }

            Console.ReadKey();
        }
    }
}
