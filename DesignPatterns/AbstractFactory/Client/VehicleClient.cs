using AbstractFactory.Contracts;

namespace AbstractFactory.Client
{
    /// <summary>
    /// The 'Client' class 
    /// </summary>
    public class VehicleClient
    {
        private IBike bike;
        private IScooter scooter;
        private string factoryType;

        public VehicleClient(IVehicleFactory factory, string type)
        {
            this.bike = factory.GetBike(type);
            this.scooter = factory.GetScooter(type);
            this.factoryType = factory.GetType().Name;
        }

        public string GetBikeName
        {
            get
            {
                return this.bike.Name();
            }
        }

        public string GetScooterName
        {
            get
            {
                return this.scooter.Name();
            }
        }

        public string GetFactoryType
        {
            get
            {
                return factoryType;
            }
        }
    }
}
