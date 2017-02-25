using AbstractFactory.Contracts;

namespace AbstractFactory.Models.ScooterModels
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class RegularScooter : IScooter
    {
        public string Name()
        {
            return "Regular Scooter- Name";
        }
    }
}
