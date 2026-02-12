using System;

namespace daysecond
{
    internal class referenceequality
    {
        int value;
        static void Main()
        {
            referenceequality obj1 = new referenceequality();
            obj1.value = 12;
            
            referenceequality obj2 = obj1;
            obj2.value = 13;
            
            Console.WriteLine(obj1.value);
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
        }
    }
}
