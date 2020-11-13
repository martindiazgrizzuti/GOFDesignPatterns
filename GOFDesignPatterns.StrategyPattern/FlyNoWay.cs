using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.StrategyPattern
{
    public class FlyNoWay : IFlyBehavior
    {
        public string fly()
        {
            return "I can't fly";
        }
    }
}
