using GOFDesignPatterns.StrategyPattern;
using System;

namespace GOFDesignPatterns.ConsoleApp
{
    class Program
    {

        enum OptionsEnum
        {
            Unknown = 0,
            StrategyPattern
        }

        static void Main(string[] args)
        {
            OptionsEnum option; ;
            while ((option = getOption()) == OptionsEnum.Unknown)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error en la opción ingresada");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }

            switch (option)
            {
                case OptionsEnum.StrategyPattern:
                    {
                        MallardDuck mallardDuck = new MallardDuck();
                        Console.WriteLine(mallardDuck.display());
                        Console.WriteLine(mallardDuck.performQuack());
                        Console.WriteLine(mallardDuck.performFly());

                        // Change behavior dynamically
                        Console.WriteLine("Changing dynamically behaviour of mallard duck...");
                        mallardDuck.setFlyBehavior(new FlyNoWay());
                        mallardDuck.setQuackBehavior(new Squeak());
                        Console.WriteLine(mallardDuck.display());
                        Console.WriteLine(mallardDuck.performQuack());
                        Console.WriteLine(mallardDuck.performFly());
                    }
                    break;
            }


            Console.ReadKey();
        }

        private static OptionsEnum getOption()
        {
            Console.WriteLine("What pattern would you test?");
            Console.WriteLine("1 - Strategy Pattern");
            Console.Write("Ingrese su opcion: ");
            String opt = Console.ReadLine();

            int pInt;
            if (int.TryParse(opt, out pInt))
            {
                if (Enum.IsDefined(typeof(OptionsEnum), pInt))
                {
                    return (OptionsEnum)Enum.Parse(typeof(OptionsEnum), opt);
                }
            }

            return OptionsEnum.Unknown;
        }

    }
}
