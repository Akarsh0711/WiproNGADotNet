using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.Collections
{
    internal class EmployeeListDemo
    {
        static void Main()
        {
            CollectionEmployee emp1 = new CollectionEmployee();
            emp1.StaffId = 1;
            emp1.StaffName = "Staff Member X";
            emp1.StaffSalary = 84724;

            CollectionEmployee emp2 = new CollectionEmployee();
            emp2.StaffId = 2;
            emp2.StaffName = "Staff Member Y";
            emp2.StaffSalary = 99922;

            CollectionEmployee emp3 = new CollectionEmployee();
            emp3.StaffId = 3;
            emp3.StaffName = "Staff Member Z";
            emp3.StaffSalary = 92211;

            ArrayList employeeList = new ArrayList();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);

            foreach(object obj in employeeList)
            {
                CollectionEmployee emp = (CollectionEmployee)obj;
                Console.WriteLine(emp);
            }
        }
    }
}
