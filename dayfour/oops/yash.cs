using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.ObjectOriented
{
    internal class PythonTrainee : ITraineeProfile
    {
        public void GetEmail()
        {
            Console.WriteLine("Email: python.trainee@example.com");
        }

        public void GetName()
        {
            Console.WriteLine("Name: Python Trainee");
        }
    }
}
