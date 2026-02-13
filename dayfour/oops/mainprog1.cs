using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.ObjectOriented
{
    internal class TraineeManagementSystem
    {
        static void Main()
        {
            ITraineeProfile[] trainees = new ITraineeProfile[]
            {
                new DotNetTrainee(), new PythonTrainee(), new JavaTrainee()
            };

            foreach(ITraineeProfile trainee in trainees)
            {
                trainee.GetName();
                trainee.GetEmail();
            }
        }
    }
}
