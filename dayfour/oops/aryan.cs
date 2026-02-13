using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.ObjectOriented
{
    internal class JavaTrainee : ITraineeProfile
    {
        public void GetEmail()
        {
            Console.WriteLine("Email: java.trainee@example.com");
        }

        public void GetName()
        {
            Console.WriteLine("Name: Java Trainee");
        }
    }
}
