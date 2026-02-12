using System;

namespace daythird
{
    internal class constructordemo
    {
        static constructordemo()
        {
            Console.WriteLine("Static Constructor Executed");
        }

        constructordemo()
        {
            Console.WriteLine("Instance Constructor Executed");
        }

        static void Main()
        {
            constructordemo demo = new constructordemo();
        }
    }
}
