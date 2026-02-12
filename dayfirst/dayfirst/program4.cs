using System;

namespace dayfirst
{
    internal class program4
    {
        static void Main()
        {
            int userAge;
            Console.WriteLine("What is your age?");
            userAge = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your Age is: " + userAge);
        }
    }
}
