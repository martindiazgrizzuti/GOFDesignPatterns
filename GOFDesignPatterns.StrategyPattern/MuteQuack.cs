using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.StrategyPattern
{
    public class MuteQuack : IQuackBehavior
    {
        public string quack()
        {
            return "<Silence>";
        }
    }
}
