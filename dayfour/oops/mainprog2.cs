using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.ObjectOriented
{
    internal class InterfaceImplementationDemo
    {
        static void Main()
        {
            MultipleInterfaceDemo demo = new MultipleInterfaceDemo();
            demo.GetName();
            demo.GetEmail();
        }
    }
}
