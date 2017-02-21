using FactoryMethod.Factory;

namespace FactoryMethod
{
    /// <summary>
    /// Factory Pattern Demo
    /// </summary>
    public class StartUpDemo
    {
        static void Main()
        {
            var vehickeFactory = new VehicleFactory();

            var scooter = vehickeFactory.GetVehicle("Scooter");
            scooter.Drive(20);

            var bike = vehickeFactory.GetVehicle("Bike");
            bike.Drive(50);
        }
    }
}
