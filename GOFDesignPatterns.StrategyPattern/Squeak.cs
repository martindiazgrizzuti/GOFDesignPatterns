using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.StrategyPattern
{
    public class Squeak : IQuackBehavior
    {
        public string quack()
        {
            return "Squeak";
        }
    }
}
