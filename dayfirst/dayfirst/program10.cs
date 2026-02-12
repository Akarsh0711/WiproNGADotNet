using System;

namespace dayfirst
{
    internal class program10
    {
        static void Main()
        {
            int x = 50;

            int y = x++ + --x + ++x + ++x + x-- + --x;
            Console.WriteLine(y);
        }
    }
}
