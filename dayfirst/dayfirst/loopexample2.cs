using System;

namespace dayfirst
{
    internal class loopexample2
    {
        public void FindFactors(int number)
        {
            for(int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine("Factor found: " + i);
                }
            }
        }
        static void Main()
        {
            int inputNum;
            Console.WriteLine("Enter a Number to find its factors: ");
            inputNum = Convert.ToInt32(Console.ReadLine());

            loopexample2 example = new loopexample2();
            example.FindFactors(inputNum);
        }
    }
}
