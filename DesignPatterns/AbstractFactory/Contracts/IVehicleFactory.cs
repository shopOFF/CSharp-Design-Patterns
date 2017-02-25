namespace AbstractFactory.Contracts
{
    /// <summary>
    /// The 'AbstractFactory' interface. 
    /// </summary>
    public interface IVehicleFactory
    {
        IBike GetBike(string bike);

        IScooter GetScooter(string scooter);
    }
}
