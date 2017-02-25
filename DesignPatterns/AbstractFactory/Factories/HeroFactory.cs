using AbstractFactory.Contracts;
using AbstractFactory.Models;
using AbstractFactory.Models.BikeModels;
using AbstractFactory.Models.ScooterModels;
using System;

namespace AbstractFactory.Factories
{
    /// <summary>
    /// The 'ConcreteFactory2' class.
    /// </summary>
    public class HeroFactory : IVehicleFactory
    {
        public IBike GetBike(string bike)
        {
            switch (bike)
            {
                case "Sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    throw new ApplicationException($"Vehicle {bike} cannot be crated!");
            }
        }

        public IScooter GetScooter(string scooter)
        {
            switch (scooter)
            {
                case "Sports":
                    return new SportsScooter();
                case "Regular":
                    return new RegularScooter();
                default:
                    throw new ApplicationException($"Vehicle {scooter} cannot be crated!");
            }
        }
    }
}
