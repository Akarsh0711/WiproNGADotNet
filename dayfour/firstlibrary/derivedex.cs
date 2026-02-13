using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.FirstLib
{
    /// <summary>
    /// Demonstrates inheritance and access modifiers.
    /// </summary>
    internal class AccessControlInheritance : AccessControlSource
    {
        public void VerifyAccess()
        {
            AccessControlInheritance derivedInstance = new AccessControlInheritance();
            Console.WriteLine(derivedInstance._publicMessage);
            Console.WriteLine(derivedInstance._protectedMessage);
            Console.WriteLine(derivedInstance._internalMessage);
            Console.WriteLine(derivedInstance._internalProtectedMessage);
        }
    }
}
