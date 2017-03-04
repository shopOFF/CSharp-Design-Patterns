using Builder.Creator;
using Builder.Models;
using System;

namespace Builder
{
    /// <summary>
    /// Builder Design Pattern Demo
    /// </summary>
    public class StartUpDemo
    {
        static void Main()
        {
            var vehicleCreator = new VehicleCreator(new HeroBuilder());
            vehicleCreator.CreateVehicle();
            var vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");

            vehicleCreator = new VehicleCreator(new HondaBuilder());
            vehicleCreator.CreateVehicle();
            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();
        }
    }
}
