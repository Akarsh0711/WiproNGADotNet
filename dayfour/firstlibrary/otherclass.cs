using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.FirstLib
{
    /// <summary>
    /// Consumes the AccessControlSource class to test access modifiers.
    /// </summary>
    internal class AccessControlConsumer
    {
        public void Consume()
        {
            AccessControlSource source = new AccessControlSource();
            Console.WriteLine(source._publicMessage);
            Console.WriteLine(source._internalMessage);
            // internal protected is accessible here because it is in the same assembly
            Console.WriteLine(source._internalProtectedMessage);
        }
    }
}
