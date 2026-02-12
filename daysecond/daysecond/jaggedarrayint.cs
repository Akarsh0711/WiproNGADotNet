using System;

namespace daysecond
{
    internal class jaggedarrayint
    {
        static void Main()
        {
            int[] group1 = new int[] { 1, 2, 3, 4 };
            int[] group2 = new int[] { 5, 6, 7 };
            int[] group3 = new int[] { 8, 9, 10, 11, 12 };
            

            int[][] jaggedInts = new int[3][];
            jaggedInts[0] = group1;
            jaggedInts[1] = group2;
            jaggedInts[2] = group3;

            Console.WriteLine("Jagged Array Data:");
            for(int i = 0; i < jaggedInts.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                foreach(int num in jaggedInts[i])
                {
                    Console.Write(num + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
