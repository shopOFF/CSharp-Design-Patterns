using AbstractFactory.Contracts;

namespace AbstractFactory.Models.BikeModels
{
    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    public class RegularBike : IBike
    {
        public string Name()
        {
            return "Regular Bike- Name";
        }
    }
}
