using System;

namespace daysecond
{
    internal class stringconcatquiz2
    {
        static void Main()
        {
            string name = "sam";
            int a = 10, b = 20, c = 30;
            
            Console.WriteLine(name + a + b + c);
            Console.WriteLine(a + b + name + c);
            Console.WriteLine(a + b + c + name);
        }
    }
}
