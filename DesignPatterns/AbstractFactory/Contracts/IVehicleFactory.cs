using AbstractFactory.Models;

namespace AbstractFactory.Contracts
{
    /// <summary>
    /// The 'AbstractFactory' interface. 
    /// </summary>
    public interface IVehicleFactory
    {
        Bike GetBike(string bike);

        Scooter GetScooter(string scooter);
    }
}
