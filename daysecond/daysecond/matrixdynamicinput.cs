using System;

namespace daysecond
{
    internal class matrixdynamicinput
    {
        static void Main()
        {
            int[,] grid = new int[2, 3];


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter value for grid[{i}][{j}]: ");
                    grid[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Grid Display:");


            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
