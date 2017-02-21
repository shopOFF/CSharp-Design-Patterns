using System;
using FactoryMethod.Contracts;
using FactoryMethod.Abstraction;
using FactoryMethod.Models;

namespace FactoryMethod.Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class VehicleFactory : AbstractVehicleFactory
    {
        public override IVehicle GetVehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException($"Vehicle {vehicle} cannot be created!");
            }
        }
    }
}
