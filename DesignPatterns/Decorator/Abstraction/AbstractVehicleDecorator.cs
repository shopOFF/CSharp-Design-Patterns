using Decorator.Contracts;

namespace Decorator.Abstraction
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public abstract class AbstractVehicleDecorator : IVehicle
    {
        private IVehicle vehicle;

        public AbstractVehicleDecorator(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string Make
        {
            get
            {
                return this.vehicle.Make;
            }
        }

        public string Model
        {
            get
            {
                return this.vehicle.Model;
            }
        }

        public decimal Price
        {
            get
            {
                return this.vehicle.Price;
            }
        }
    }
}
