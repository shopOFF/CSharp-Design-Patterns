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
            Console.WriteLine($"{hondaClient.GetBikeName}");
            Console.WriteLine($"{hondaClient.GetScooterName}");

            hondaClient = new VehicleClient(hondaFactory, "Sports");
            Console.WriteLine($"{hondaClient.GetBikeName}");
            Console.WriteLine($"{hondaClient.GetScooterName}");

            // Hero Factory
            IVehicleFactory heroFactory = new HondaFactory();
            VehicleClient heroClient = new VehicleClient(heroFactory, "Regular");

            Console.WriteLine("******* Hero **********");
            Console.WriteLine($"{heroClient.GetBikeName}");
            Console.WriteLine($"{heroClient.GetScooterName}");

            heroClient = new VehicleClient(heroFactory, "Sports");
            Console.WriteLine($"{heroClient.GetBikeName}");
            Console.WriteLine($"{heroClient.GetScooterName}");
        }
    }
}
