using AbstractFactory.Contracts;

namespace AbstractFactory.Models.BikeModels
{
    /// <summary>
    /// The 'ProductA2' class
    /// </summary>
    public class SportsBike : IBike
    {
        public string Name()
        {
            return "Sports Bike- Name";
        }
    }
}
