using System;

namespace daysecond
{
    internal class arraydelete
    {
        public void DeleteElement()
        {
            Console.WriteLine("Enter Array Size:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];
            Console.WriteLine($"Enter {size} Elements:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Element to Delete:");
            int deleteTarget = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                if (numbers[i] == deleteTarget)
                {

                    for(int j = i; j < size - 1; j++)
                    {
                        numbers[j] = numbers[j + 1];
                    }
                    size--;
                }
            }

            Console.WriteLine("Array after Deletion:");
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void Main()
        {
            new arraydelete().DeleteElement();
        }
    }
}
