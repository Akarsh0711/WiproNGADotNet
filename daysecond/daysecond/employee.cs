using System;

namespace daysecond
{
    internal class employee
    {
        public int employeeId;
        public string empName;
        public double basicSalary;

        public void DisplayDetails()
        {
            Console.Write($"ID: {employeeId} | Name: {empName} | Salary: {basicSalary}");
        }
    }
}
