using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.ObjectOriented
{
    internal class MultipleInterfaceDemo : INameable, IContactable
    {
        public void GetEmail()
        {
            Console.WriteLine("Email from MultipleInterfaceDemo Class");
        }

        public void GetName()
        {
            Console.WriteLine("Name from MultipleInterfaceDemo Class...");
        }
    }
}
