using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.Collections
{
    internal class CollectionEmployee
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public double StaffSalary { get; set; }

        public override string ToString()
        {
            return $"ID: {StaffId}, Name: {StaffName}, Salary: {StaffSalary}";
        }
    }
}
