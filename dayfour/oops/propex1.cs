using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.ObjectOriented
{
    class EmployeeDetails
    {
        private int _empId;
        private string _empName;
        private double _empSalary;

        public int EmployeeId
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public string EmployeeName
        {
            get { return _empName; }
            set { _empName = value; }
        }

        public double EmployeeSalary 
        { 
            get { return _empSalary; }
            set {  _empSalary = value; }
        }
    }

    internal class PropertyImplementationDemo
    {
        static void Main()
        {
            EmployeeDetails emp1 = new EmployeeDetails();
            emp1.EmployeeId = 1;
            emp1.EmployeeName = "Employee A";
            emp1.EmployeeSalary = 38234;

            EmployeeDetails emp2 = new EmployeeDetails();
            emp2.EmployeeId = 2;
            emp2.EmployeeName = "Employee B";
            emp2.EmployeeSalary = 73234;

            EmployeeDetails emp3 = new EmployeeDetails();
            emp3.EmployeeId = 3;
            emp3.EmployeeName = "Employee C";
            emp3.EmployeeSalary = 77233;

            Console.WriteLine("Employee Details:");
            Console.WriteLine($"ID: {emp1.EmployeeId}, Name: {emp1.EmployeeName}, Salary: {emp1.EmployeeSalary}");
            Console.WriteLine($"ID: {emp2.EmployeeId}, Name: {emp2.EmployeeName}, Salary: {emp2.EmployeeSalary}");
            Console.WriteLine($"ID: {emp3.EmployeeId}, Name: {emp3.EmployeeName}, Salary: {emp3.EmployeeSalary}");
        }
    }
}
