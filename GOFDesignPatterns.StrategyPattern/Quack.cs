using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.StrategyPattern
{
    public class Quack : IQuackBehavior
    {

        string IQuackBehavior.quack()
        {
            return "Quack";
        }
    }
}
