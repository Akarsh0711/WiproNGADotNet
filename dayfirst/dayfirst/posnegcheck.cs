using System;

namespace dayfirst
{
    internal class posnegcheck
    {
        public void CheckSign(int number)
        {
            if(number >= 0)
            {
                Console.WriteLine("Number is Positive");
            } 
            else
            {
                Console.WriteLine("Number is Negative");
            }
        }
        static void Main()
        {
            int inputNum;
            Console.WriteLine("Enter Number:");
            inputNum = Convert.ToInt32(Console.ReadLine());

            posnegcheck checker = new posnegcheck();
            checker.CheckSign(inputNum);
        }
    }
}
