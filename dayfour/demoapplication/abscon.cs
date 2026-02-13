using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.DemoApp
{
    /// <summary>
    /// Represents an abstract student entity.
    /// </summary>
    abstract class AbstractStudent
    {
        int _studentId;
        string _name;
        double _cgpa;

        public AbstractStudent(int id, string name, double cgpa)
        {
            this._studentId = id;
            this._name = name;
            this._cgpa = cgpa;
        }

        public override string ToString()
        {
            return $"ID: {_studentId}, Name: {_name}, CGPA: {_cgpa}";
        }
    }

    class ScienceStudent : AbstractStudent
    {
        public ScienceStudent(int id, string name, double cgpa) : base(id, name, cgpa)
        {
        }
    }

    class ArtsStudent : AbstractStudent
    {
        public ArtsStudent(int id, string name, double cgpa) : base(id, name, cgpa)
        {
        }
    }

    class CommerceStudent : AbstractStudent
    {
        public CommerceStudent(int id, string name, double cgpa) : base(id, name, cgpa)
        {
        }
    }

    internal class AbstractConstructorDemo
    {
        static void Main()
        {
            AbstractStudent[] students = new AbstractStudent[] {
                new CommerceStudent(1, "Student A", 8.3),
                new ArtsStudent(2, "Student B", 9.1),
                new ScienceStudent(3, "Student C", 9.3)
            };

            foreach(AbstractStudent s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}
