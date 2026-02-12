using System;

namespace daysecond
{
    internal class matrixaddition
    {
        public void PerformAddition()
        {
            int[,] matrixA = new int[10, 10];
            int[,] matrixB = new int[10, 10];
            int[,] resultMatrix = new int[10, 10];

            int rows, cols;
            Console.WriteLine("Enter Rows and Columns for Matrices:");
            rows = Convert.ToInt32(Console.ReadLine());
            cols = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("--- Input Matrix A ---");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"A[{i}][{j}]: ");
                    matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("--- Input Matrix B ---");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"B[{i}][{j}]: ");
                    matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            Console.WriteLine("--- Matrix A ---");
            PrintMatrix(matrixA, rows, cols);

            Console.WriteLine("--- Matrix B ---");
            PrintMatrix(matrixB, rows, cols);

            Console.WriteLine("--- Result (Addition) ---");
            PrintMatrix(resultMatrix, rows, cols);
        }

        private void PrintMatrix(int[,] mat, int r, int c)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(mat[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            new matrixaddition().PerformAddition();
        }
    }
}
