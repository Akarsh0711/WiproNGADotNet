using System;

namespace dayfirst
{
    internal class program5
    {
        static void Main()
        {
            int num1, num2, result;
            
            Console.WriteLine("Please Enter Two Numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine("Sum             : " + result);

            result = num1 - num2;
            Console.WriteLine("Difference      : " + result);

            result = num1 * num2;
            Console.WriteLine("Product         : " + result);
        }
    }
}
