using System;

namespace daythird
{
    internal class sumoverloading
    {
        public int CalculateSum()
        {
            return 10;
        }

        public int CalculateSum(int val)
        {
            return val + 10;
        }

        public int CalculateSum(int val1, int val2)
        {
            return val1 + val2;
        }

        static void Main()
        {
            sumoverloading calc = new sumoverloading();

            Console.WriteLine("Sum (No Args)    : " + calc.CalculateSum());
            Console.WriteLine("Sum (One Arg)    : " + calc.CalculateSum(82));
            Console.WriteLine("Sum (Two Args)   : " + calc.CalculateSum(81, 62));
        }
    }
}
