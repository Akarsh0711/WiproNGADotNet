using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayFour.FirstLib;

namespace DayFour.SecondLib
{
    /// <summary>
    /// Demonstrates inheritance across different assemblies.
    /// </summary>
    internal class CrossAssemblyInheritance : AccessControlSource
    {
        public void ShowInfo()
        {
            CrossAssemblyInheritance inheritanceDemo = new CrossAssemblyInheritance();
            Console.WriteLine(inheritanceDemo._publicMessage);
            Console.WriteLine(inheritanceDemo._protectedMessage);
            Console.WriteLine(inheritanceDemo._internalProtectedMessage);
        }
    }
}
