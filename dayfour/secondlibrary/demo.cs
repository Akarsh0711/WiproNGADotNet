using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayFour.FirstLib;

namespace DayFour.SecondLib
{
    /// <summary>
    /// Demonstrates consuming a public class from another assembly.
    /// </summary>
    public class CrossAssemblyConsumer
    {
        public void Consume()
        {
            AccessControlSource source = new AccessControlSource();
            Console.WriteLine(source._publicMessage);
        }
    }
}
