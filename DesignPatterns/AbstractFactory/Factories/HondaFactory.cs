using AbstractFactory.Contracts;
using AbstractFactory.Models;
using System;

namespace AbstractFactory.Factories
{
    public class HondaFactory : IVehicleFactory
    {
        public Bike GetBike(string bike)
        {
            throw new NotImplementedException();
        }

        public Scooter GetScooter(string scooter)
        {
            throw new NotImplementedException();
        }
    }
}
