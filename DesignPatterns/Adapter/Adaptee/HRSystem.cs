namespace Adapter.Adaptee
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class HRSystem
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];

            employees[0] = new string[] { "100", "Deepak", "Team Leader" };
            employees[1] = new string[] { "101", "Gosho", "Developer" };
            employees[2] = new string[] { "102", "Pesho", "Developer" };
            employees[3] = new string[] { "103", "Kolio", "Tester" };

            return employees;
        }
    }
}
