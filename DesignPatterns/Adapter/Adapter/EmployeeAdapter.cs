using Adapter.Adaptee;
using Adapter.Contracts;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class EmployeeAdapter : HRSystem, ITarget
    {
        public string GetEmployeeList()
        {
            StringBuilder employeeList = new StringBuilder();
            string[][] employees = GetEmployees();

            foreach (string[] employee in employees)
            {
                employeeList.AppendLine(string.Join(", ", employee));
            }

            return employeeList.ToString();
        }
    }
}
