using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.ObjectOriented
{
    class StaffMember
    {
        public int StaffId { get; set; } 
        public string FullName { get; set; }
        public double AnnualSalary { get; set;}

        public override string ToString()
        {
            return $"ID: {StaffId}, Name: {FullName}, Salary: {AnnualSalary}";
        }
    }

    internal class AutoPropertyDemo
    {
        static void Main()
        {
            StaffMember staff1 = new StaffMember();
            staff1.StaffId = 1;
            staff1.FullName = "Staff A";
            staff1.AnnualSalary = 88323;

            StaffMember staff2 = new StaffMember();
            staff2.StaffId = 2;
            staff2.FullName = "Staff B";
            staff2.AnnualSalary = 90032;

            Console.WriteLine(staff1);
            Console.WriteLine(staff2);
        }
    }
}
