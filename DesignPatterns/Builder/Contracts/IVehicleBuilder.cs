using Builder.Models;

namespace Builder.Contracts
{
    /// <summary>
    /// The 'Builder' interface
    /// </summary>
    public interface IVehicleBuilder
    {
        void SetModel();

        void SetEngine();

        void SetTransmission();

        void SetBody();

        void SetAccessories();

        Vehicle GetVehicle();
    }
}
