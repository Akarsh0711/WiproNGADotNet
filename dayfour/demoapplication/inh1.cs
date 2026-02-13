using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.DemoApp
{
    class BaseClassDemo
    {
        public void ShowMessage()
        {
            Console.WriteLine("Show Method From Class First...");
        }
    }

    class DerivedClassDemo : BaseClassDemo
    { 
        public void DisplayMessage()
        {
            Console.WriteLine("Display Method from Class Second...");
        }
    }

    internal class InheritanceBasics
    {
        static void Main()
        {
            DerivedClassDemo demo = new DerivedClassDemo(); 
            demo.ShowMessage();
            demo.DisplayMessage();
        }
    }
}
