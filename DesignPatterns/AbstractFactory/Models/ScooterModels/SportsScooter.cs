using AbstractFactory.Contracts;

namespace AbstractFactory.Models.ScooterModels
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class SportsScooter : IScooter
    {
        public string Name()
        {
            return "Sports Scooter- Name";
        }
    }
}
