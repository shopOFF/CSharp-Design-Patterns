using AbstractFactory.Client;
using AbstractFactory.Contracts;
using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    /// <summary>
    /// Abstract Factory Pattern Demo
    /// </summary>
    public class StartUpDemo
    {
        static void Main()
        {
            // Honda Factory
            IVehicleFactory hondaFactory = new HondaFactory();
            VehicleClient hondaClient = new VehicleClient(hondaFactory, "Regular");

            Console.WriteLine("******* Honda **********");
            Console.WriteLine($"Current Factory- {hondaClient.GetFactoryType}");
            Console.WriteLine($"{hondaClient.GetBikeName}");
            Console.WriteLine($"{hondaClient.GetScooterName}");

            hondaClient = new VehicleClient(hondaFactory, "Sports");
            Console.WriteLine($"Current Factory- {hondaClient.GetFactoryType}");
            Console.WriteLine($"{hondaClient.GetBikeName}");
            Console.WriteLine($"{hondaClient.GetScooterName}");


            // Hero Factory
            IVehicleFactory heroFactory = new HeroFactory();
            VehicleClient heroClient = new VehicleClient(heroFactory, "Regular");

            Console.WriteLine("******* Hero **********");
            Console.WriteLine($"Current Factory- {heroClient.GetFactoryType}");
            Console.WriteLine($"{heroClient.GetBikeName}");
            Console.WriteLine($"{heroClient.GetScooterName}");

            heroClient = new VehicleClient(heroFactory, "Sports");
            Console.WriteLine($"Current Factory- {heroClient.GetFactoryType}");
            Console.WriteLine($"{heroClient.GetBikeName}");
            Console.WriteLine($"{heroClient.GetScooterName}");
        }
    }
}
