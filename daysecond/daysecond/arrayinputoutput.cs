using System;

namespace daysecond
{
    internal class arrayinputoutput
    {
        public void ProcessArray()
        {
            int size;
            Console.WriteLine("Enter Array Size:");
            size = Convert.ToInt32(Console.ReadLine());
            
            int[] numbers = new int[size];
            Console.WriteLine($"Enter {size} Elements:");
            
            for(int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Stored Elements are:");
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void Main()
        {
            arrayinputoutput demo = new arrayinputoutput();
            demo.ProcessArray();
        }
    }
}
