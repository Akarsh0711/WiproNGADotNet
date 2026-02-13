using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.ObjectOriented
{
    internal class DotNetTrainee : ITraineeProfile
    {
        public void GetEmail()
        {
            Console.WriteLine("Email: dotnet.trainee@example.com");
        }

        public void GetName()
        {
            Console.WriteLine("Name: DotNet Trainee");
        }
    }
}
