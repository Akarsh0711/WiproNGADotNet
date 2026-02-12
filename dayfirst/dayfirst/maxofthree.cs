using System;

namespace dayfirst
{
    internal class maxofthree
    {
        public void FindMax(int num1, int num2, int num3)
        {
            int maxVal = num1;
            if(maxVal < num2)
            {
                maxVal = num2;
            }
            if(maxVal < num3)
            {
                maxVal = num3;
            }
            Console.WriteLine("Maximum in 3 numbers is: " + maxVal);
        }
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter 3 Numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            maxofthree maxFinder = new maxofthree();
            maxFinder.FindMax(a, b, c);
        }
    }
}
