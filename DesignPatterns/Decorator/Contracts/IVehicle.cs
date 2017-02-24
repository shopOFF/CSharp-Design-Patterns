namespace Decorator.Contracts
{
    /// <summary>
    /// The 'Component' interface
    /// </summary>
    public interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        decimal Price { get; }
    }
}
