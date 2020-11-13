using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.StrategyPattern
{
    public class FlyWithWings : IFlyBehavior
    {
        public string fly()
        {
            return "I'm flying";
        }
    }
}
