using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.DemoApp
{
    abstract class AbstractTraining
    {
        public abstract void DisplayName();
        public abstract void DisplayEmail();
    }

    class OnlineTraining : AbstractTraining
    {
        public override void DisplayEmail()
        {
            Console.WriteLine("Contact: online@example.com");
        }

        public override void DisplayName()
        {
            Console.WriteLine("Mode: Online Training");
        }
    }

    class OfflineTraining : AbstractTraining
    {
        public override void DisplayEmail()
        {
            Console.WriteLine("Contact: offline@example.com");
        }

        public override void DisplayName()
        {
            Console.WriteLine("Mode: Offline Classroom Training");
        }
    }

    class HybridTraining : AbstractTraining
    {
        public override void DisplayEmail()
        {
            Console.WriteLine("Contact: hybrid@example.com");
        }

        public override void DisplayName()
        {
            Console.WriteLine("Mode: Hybrid Training");
        }
    }

    internal class AbstractMethodDemo
    {
        static void Main()
        {
            AbstractTraining[] trainingModules = new AbstractTraining[]
            {
                new HybridTraining(), new OnlineTraining(), new OfflineTraining()
            };

            foreach(AbstractTraining module in trainingModules)
            {
                module.DisplayName();
                module.DisplayEmail();
            }
        }
    }
}
