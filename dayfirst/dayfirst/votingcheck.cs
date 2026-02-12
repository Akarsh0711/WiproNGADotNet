using System;

namespace dayfirst
{
    internal class votingcheck
    {
        public void VerifyAge(int age)
        {
            if(age >= 18)
            {
                Console.WriteLine("Eligible to vote");
            } 
            else
            {
                Console.WriteLine("Not eligible to vote");
            }
        }
        static void Main()
        {
            int inputAge;
            Console.WriteLine("Enter Age:");
            inputAge = Convert.ToInt32(Console.ReadLine());
            
            votingcheck checker = new votingcheck();
            checker.VerifyAge(inputAge);
        }
    }
}
