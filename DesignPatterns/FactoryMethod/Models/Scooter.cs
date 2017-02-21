using FactoryMethod.Contracts;
using System;

namespace FactoryMethod.Models
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Scooter : IVehicle
    {
        public void Drive(int kilometers)
        {
            Console.WriteLine($"Drive the Scooter: {kilometers}");
        }
    }
}
