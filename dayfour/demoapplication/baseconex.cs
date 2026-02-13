using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.DemoApp
{
    class BaseStaff
    {
        int _staffId;
        string _name;
        double _salary;

        public BaseStaff(int id, string name, double salary)
        {
            this._staffId = id;
            this._name = name;
            this._salary = salary;
        }

        public override string ToString()
        {
            return $"ID: {_staffId}, Name: {_name}, Salary: {_salary}";
        }
    }

    class FullTimeStaff : BaseStaff
    {
        public FullTimeStaff(int id, string name, double salary) : base(id, name, salary)
        {
        }
    }

    class PartTimeStaff : BaseStaff
    {
        public PartTimeStaff(int id, string name, double salary) : base(id, name, salary)
        {
        }
    }

    internal class StaffConstructorDemo
    {
        static void Main()
        {
            BaseStaff[] staffMembers = new BaseStaff[]
            {
                new FullTimeStaff(101, "Staff A", 88423.22),
                new PartTimeStaff(102, "Staff B", 87722.11)
            };

            foreach (BaseStaff staff in staffMembers)
            {
                Console.WriteLine(staff);
            }
        }
    }
}
