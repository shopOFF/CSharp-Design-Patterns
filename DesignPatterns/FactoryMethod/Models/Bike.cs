using FactoryMethod.Contracts;
using System;

namespace FactoryMethod.Models
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Bike : IVehicle
    {
        public void Drive(int kilometers)
        {
            Console.WriteLine($"Drive the Bike: {kilometers}km.");
        }
    }
}
