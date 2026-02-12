using System;

namespace daysecond
{
    internal class matrixstaticinit
    {
        static void Main()
        {

            int[,] numbers = {
                                { 1, 2 },
                                { 3, 4 }
                             };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
