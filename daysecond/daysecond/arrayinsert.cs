using System;

namespace daysecond
{
    internal class arrayinsert
    {
        public void InsertElement()
        {

            Console.WriteLine("Enter Array Size:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n + 1];

            Console.WriteLine($"Enter {n} Elements:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Element to Insert:");
            int newValue = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Position to Insert (1-based):");
            int pos = Convert.ToInt32(Console.ReadLine());


             if (pos > 0 && pos <= n + 1)
            {
                for (int i = n; i >= pos; i--)
                {
                   numbers[i] = numbers[i - 1];
                }
                numbers[pos - 1] = newValue;
                n++;
            }
            
            Console.WriteLine("Array after Insertion:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static void Main()
        {
            new arrayinsert().InsertElement();
        }
    }
}
