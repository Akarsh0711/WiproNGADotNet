using System;

namespace dayfirst
{
    internal class loopexample1
    {
        public void RunLoop()
        {
            int i = 0;
            int limit = 10;
            while(i < limit)
            {
                Console.WriteLine("I am Pranav");
                i++;
            }
        }
        static void Main()
        {
            loopexample1 example = new loopexample1();
            example.RunLoop();
        }
    }
}
