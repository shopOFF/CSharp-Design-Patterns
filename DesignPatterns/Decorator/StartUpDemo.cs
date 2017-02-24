using Decorator.Contracts;
using Decorator.Decorator;
using Decorator.Models;
using System;

namespace Decorator
{
    /// <summary>
    /// Decorator Pattern Demo
    /// </summary>
    public class StartUpDemo
    {
        static void Main()
        {
            // Basic vehicle
            IVehicle hondaCar = new HondaCity();
            Console.WriteLine("Honda City base price is : {0} $", hondaCar.Price);

            // Special offer
            VehicleSpecialOffer hondaCarSpecialOffer = new VehicleSpecialOffer(hondaCar);
            hondaCarSpecialOffer.DiscountPercentage = 50;
            hondaCarSpecialOffer.Offer = $"{hondaCarSpecialOffer.DiscountPercentage} % discount";

            Console.WriteLine($"{hondaCarSpecialOffer.Offer} @ ShopoffAuto Special Offer and price is : {hondaCarSpecialOffer.Price} $");
        }
    }
}
