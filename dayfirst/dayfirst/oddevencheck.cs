using System;

namespace dayfirst
{
    internal class oddevencheck
    {
        public void VerifyNumber(int number)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            } 
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
        static void Main()
        {
            int checkNum;
            Console.WriteLine("Enter Number:");
            checkNum = Convert.ToInt32(Console.ReadLine());

            oddevencheck checker = new oddevencheck();
            checker.VerifyNumber(checkNum);
        }
    }
}
