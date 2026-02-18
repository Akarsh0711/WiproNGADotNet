using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class DipMain
    {
        static void Main()
        {
            ITrainerData trainer1 = new DotnetTrainerInfo();
            ITrainerData trainer2 = new PythonTrainerInfo();

            
            

            
            
            
            

            TrainerUtil[] arr = new TrainerUtil[]
            {
                new TrainerUtil(trainer1),
                new TrainerUtil(trainer2)
            };

            foreach (TrainerUtil t in arr)
            {
                t.ShowTrainerInfo();
            }

        }
    }
}
