using Adapter.Adapter;
using Adapter.Client;
using Adapter.Contracts;

namespace Adapter
{
    /// <summary>
    /// Adapter Design Pattern Demo
    /// </summary>
    public class StartUpDemo
    {
        static void Main()
        {
            ITarget iTarget = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(iTarget);
            client.ShowEmployeeList();
        }
    }
}
