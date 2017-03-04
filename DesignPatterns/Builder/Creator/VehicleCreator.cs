using Builder.Contracts;
using Builder.Models;

namespace Builder.Creator
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public class VehicleCreator
    {
        private readonly IVehicleBuilder objBuilder;

        public VehicleCreator(IVehicleBuilder builder)
        {
            objBuilder = builder;
        }

        public void CreateVehicle()
        {
            objBuilder.SetModel();
            objBuilder.SetEngine();
            objBuilder.SetBody();
            objBuilder.SetTransmission();
            objBuilder.SetAccessories();
        }

        public Vehicle GetVehicle()
        {
            return objBuilder.GetVehicle();
        }
    }
}
