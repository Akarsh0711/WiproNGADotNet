using System;

namespace daysecond
{
    internal class matrixinputoutput
    {
        public void ProcessMatrix()
        {
            int[,] matrix = new int[10, 10];
            int rows, cols;
            
            Console.WriteLine("Enter Number of Rows and Columns:");
            rows = Convert.ToInt32(Console.ReadLine());
            cols = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Matrix Elements:");
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"Enter element at [{i}][{j}]:");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix Display:");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i,j] + "  ");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            new matrixinputoutput().ProcessMatrix();
        }
    }
}
