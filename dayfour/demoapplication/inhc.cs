using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.DemoApp
{
    class StaticBase
    {
        static StaticBase()
        {
            Console.WriteLine("Base Class Static Constructor...");
        }
        public StaticBase()
        {
            Console.WriteLine("Base Class Constructor...");
        }
    }

    class StaticDerived : StaticBase
    { 
        static StaticDerived()
        {
            Console.WriteLine("Derived Class Static Constructor...");
        }
        public StaticDerived()
        {
            Console.WriteLine("Derived Class Constructor...");
        }

        static void Main()
        {
            StaticDerived instance = new StaticDerived();
        }
    }
}
