using System;

namespace daysecond
{
    internal class arraysum
    {
        public void CalculateSum()
        {
            int size;
            Console.WriteLine("Enter Array Size:");
            size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];
            Console.WriteLine($"Enter {size} Elements:");

            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int totalSum = 0;
            for(int i = 0; i < size; i++)
            {
                totalSum += numbers[i];
            }
            Console.WriteLine("Total Sum: " + totalSum);
        }
        static void Main()
        {
            arraysum demo = new arraysum();
            demo.CalculateSum();
        }
    }
}
