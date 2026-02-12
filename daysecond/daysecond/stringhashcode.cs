using System;

namespace daysecond
{
    internal class stringhashcode
    {
        static void Main()
        {
            string name1 = "Harsh";
            string name2 = "Abhishek";
            string name3 = "Vinay";
            string name4 = "Harsh";

            Console.WriteLine(name1.GetHashCode());
            Console.WriteLine(name2.GetHashCode());
            Console.WriteLine(name3.GetHashCode());
            Console.WriteLine(name4.GetHashCode()); 

        }
    }
}
