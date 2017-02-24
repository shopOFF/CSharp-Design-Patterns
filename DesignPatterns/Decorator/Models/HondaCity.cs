using Decorator.Contracts;

namespace Decorator.Models
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class HondaCity : IVehicle
    {
        public string Make
        {
            get
            {
                return "HondaCity";
            }
        }

        public string Model
        {
            get
            {
                return "CNG";
            }
        }

        public decimal Price
        {
            get
            {
                return 60000M;
            }
        }
    }
}
