using System;

namespace daysecond
{
    internal class arrayminmax
    {
        public void FindMinMax()
        {
            Console.WriteLine("Enter Array Size:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];
            Console.WriteLine($"Enter {size} Elements:");

            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxValue = numbers[0];
            int minValue = numbers[0];

            for(int i = 0; i < size; i++)
            {
                if (maxValue < numbers[i])
                {
                    maxValue = numbers[i];
                }
                if (minValue > numbers[i])
                {
                    minValue = numbers[i];
                }
            }
            Console.WriteLine("Maximum Value: " + maxValue);
            Console.WriteLine("Minimum Value: " + minValue);
        }
        static void Main()
        {
            arrayminmax demo = new arrayminmax();
            demo.FindMinMax();
        }
    }
}
