using Adapter.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Client
{
    /// <summary>
    /// The 'Client' class
    /// </summary>
    public class ThirdPartyBillingSystem
    {
        private ITarget employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            string employee = employeeSource.GetEmployeeList();
            //To DO: Implement you business logic

            Console.WriteLine("######### Employee List ##########");
            Console.WriteLine(employee);
        }
    }
}
