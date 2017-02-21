using FactoryMethod.Contracts;

namespace FactoryMethod.Abstraction
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class AbstractVehicleFactory 
    {
        public abstract IVehicle GetVehicle(string Vehicle);
    }
}
