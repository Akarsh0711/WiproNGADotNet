using System;

namespace dayfirst
{
    internal class loopexample3
    {
        public void CalculateFactorial(int number)
        {
            int fact = 1;
            int i = 1;
            while (i <= number)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine("Factorial is: " + fact);
        }
        static void Main()
        {
            int inputNum;
            Console.WriteLine("Enter Number:");
            inputNum = Convert.ToInt32(Console.ReadLine());
            
            loopexample3 example = new loopexample3();
            example.CalculateFactorial(inputNum);
        }
    }
}
