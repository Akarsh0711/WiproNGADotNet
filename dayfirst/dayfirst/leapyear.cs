using System;

namespace dayfirst
{
    internal class leapyear
    {
        public void CheckYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("It's a Leap Year");
            } 
            else
            {
                Console.WriteLine("It's Not a Leap Year");
            }
        }
        static void Main()
        {
            int inputYear;
            Console.WriteLine("Enter Year:");
            inputYear = Convert.ToInt32(Console.ReadLine());
            
            leapyear checker = new leapyear();
            checker.CheckYear(inputYear);
        }
    }
}
