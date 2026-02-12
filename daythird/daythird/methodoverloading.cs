using System;

namespace daythird
{
    internal class methodoverloading
    {
        public void Display(int val)
        {
            Console.WriteLine("Display Method (Integer): " + val);
        }

        public void Display(double val)
        {
            Console.WriteLine("Display Method (Double): " + val);
        }

        public void Display(string val)
        {
            Console.WriteLine("Display Method (String): " + val);
        }

        static void Main()
        {
            methodoverloading demo = new methodoverloading();
            demo.Display(102);
            demo.Display(212.5);
            demo.Display("Wipro");
        }
    }
}
