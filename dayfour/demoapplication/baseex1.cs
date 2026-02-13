using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.DemoApp
{
    class BaseWorker
    {
        public void ShowDetails()
        {
            Console.WriteLine("Message from BaseWorker...");
        }
    }

    class WorkerPayroll : BaseWorker
    {
        public new void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Message from WorkerPayroll...");
        }
    }

    internal class BaseKeywordDemo
    {
        static void Main()
        {
            WorkerPayroll payroll = new WorkerPayroll();
            payroll.ShowDetails();
        }
    }
}
