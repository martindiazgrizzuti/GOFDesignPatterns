using GOFDesignPatterns.ObserverPattern;
using GOFDesignPatterns.StrategyPattern;
using System;

namespace GOFDesignPatterns.ConsoleApp
{
    class Program
    {

        enum OptionsEnum
        {
            Unknown = 0,
            StrategyPattern,
            ObserverPattern
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
                case OptionsEnum.ObserverPattern:
                    {
                        //WeatherData weatherData = new WeatherData();
                        //CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
                        //ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData, 29.92f);
                        ObserverPattern.SecondSolution.WeatherData weatherData = new ObserverPattern.SecondSolution.WeatherData();
                        ObserverPattern.SecondSolution.CurrentConditionsDisplay currentConditionsDisplay = new ObserverPattern.SecondSolution.CurrentConditionsDisplay(weatherData);
                        ObserverPattern.SecondSolution.ForecastDisplay forecastDisplay = new ObserverPattern.SecondSolution.ForecastDisplay(weatherData, 29.92f);
                        Console.WriteLine("Setting measurements (t, h, p) = (80, 65, 30.4)...");
                        weatherData.setMeasurements(80, 65, 30.4f);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(currentConditionsDisplay.display());
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(forecastDisplay.display());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Setting measurements (t, h, p) = (82, 70, 29.2)...");
                        weatherData.setMeasurements(82, 70, 29.2f);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(currentConditionsDisplay.display());
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(forecastDisplay.display());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Setting measurements (t, h, p) = (78, 90, 29.2)...");
                        weatherData.setMeasurements(78, 90, 29.2f);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(currentConditionsDisplay.display());
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(forecastDisplay.display());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
            }


            Console.ReadKey();
        }

        private static OptionsEnum getOption()
        {
            Console.WriteLine("What pattern would you test?");
            Console.WriteLine("1 - Strategy Pattern");
            Console.WriteLine("2 - Observer Pattern");
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
