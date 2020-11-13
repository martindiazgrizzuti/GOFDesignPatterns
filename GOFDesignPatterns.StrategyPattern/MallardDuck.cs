using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override string display()
        {
            return "I'm a real Mallard duck";
        }
    }
}
