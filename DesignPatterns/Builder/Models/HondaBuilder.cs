﻿using Builder.Contracts;

namespace Builder.Models
{
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    public class HondaBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();

        public void SetModel()
        {
            objVehicle.Model = "Honda";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "4 Stroke";
        }

        public void SetTransmission()
        {
            objVehicle.Transmission = "155 Km/hr";
        }

        public void SetBody()
        {
            objVehicle.Body = "Plastic";
        }

        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Seat Cover");
            objVehicle.Accessories.Add("Rear Mirror");
            objVehicle.Accessories.Add("Helmet");
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }
}