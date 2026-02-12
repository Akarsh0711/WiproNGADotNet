using System;

namespace daythird
{
    internal class refkeywordfactorial
    {
        public void ComputeFactorial(int number, ref int result)
        {
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
        }
        static void Main()
        {
            int inputNum = 8;
            int factorialResult = 1;
            
            refkeywordfactorial calculator = new refkeywordfactorial();
            calculator.ComputeFactorial(inputNum, ref factorialResult);
            
            Console.WriteLine($"Calculated Factorial: {factorialResult}");
        }
    }
}
