using System;

namespace daysecond
{
    internal class arraysearch
    {
        public void SearchElement()
        {
            Console.WriteLine("Enter Array Size:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];
            Console.WriteLine($"Enter {size} Elements:");

            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Element to Search:");
            int searchTarget = Convert.ToInt32(Console.ReadLine());
            
            bool isFound = false;
            for(int i = 0; i < size; i++)
            {
                if (numbers[i] == searchTarget)
                {
                    Console.WriteLine($"Element found at index {i}");
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Element NOT found.");
            }
        }
        static void Main()
        {
            new arraysearch().SearchElement();
        }
    }
}
