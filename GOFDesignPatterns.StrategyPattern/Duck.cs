using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.StrategyPattern
{
    public abstract class Duck
    {
        /// <summary>
        ///     Design Principle I:
        ///         Identify the aspects of your application that vary adn separete 
        ///         them from what stays the same. The result will be fewer unintended
        ///         consequences from code changes and more flexibility in your systems.
        ///     Design Principle II:
        ///         Program to an interface (super-type), not an implementation.
        ///     Design Principle III:
        ///         Favor composition over inheritance. It gives more flexibility. Not only
        ///         let you encapsulate a family of algorithms into their own set of classes,
        ///         but it lets you change behavior at runtime as long as the object you're
        ///         composing with implements the correct behaviour interface.
        /// 
        ///     The Duck classes won't need to know any of the implementation details for
        ///     their own behaviors. The Duck subclasses will use a behavior represented by
        ///     an interface (FlyBehavior and QuackBehavior), so that the actual implementation
        ///     of the behavior won't be locked into the Duck subclass.
        ///     We can add new behaviors without modifying any of our existing behavior classes
        ///     or touching any of the Duck classes that use flying behaviors.
        /// 
        /// </summary>
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public abstract String display();

        public void setFlyBehavior(IFlyBehavior _flyBehavior)
        {
            flyBehavior = _flyBehavior;
        }

        public void setQuackBehavior(IQuackBehavior _quackBehavior)
        {
            quackBehavior = _quackBehavior;
        }

        public String performQuack()
        {
            return quackBehavior.quack();
        }

        public String performFly()
        {
            return flyBehavior.fly();
        }

        public String swim()
        {
            return "All ducks float, even decoys!";
        }
    }
}
